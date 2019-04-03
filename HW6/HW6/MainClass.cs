using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ordertest {

    class MainClass {
        public static void Main() {
            try {
                Customer customer1 = new Customer(1, "Customer1");
                Customer customer2 = new Customer(2, "Customer2");

                Goods milk = new Goods(1, "Milk", 69.9);
                Goods eggs = new Goods(2, "eggs", 4.99);
                Goods apple = new Goods(3, "apple", 5.59);

                OrderDetail orderDetails1 = new OrderDetail(1, apple, 8);
                OrderDetail orderDetails2 = new OrderDetail(2, eggs, 2);
                OrderDetail orderDetails3 = new OrderDetail(3, milk, 1);

                Order order1 = new Order(1, customer1);
                Order order2 = new Order(2, customer2);
                Order order3 = new Order(3, customer2);
                order1.AddDetails(orderDetails1);
                order1.AddDetails(orderDetails2);
                //order1.AddDetails(orderDetails3);
                //order1.AddOrderDetails(orderDetails3);
                order3.AddDetails(orderDetails2);
                //order3.AddDetails(orderDetails3);
                order2.AddDetails(orderDetails3);

                
                OrderService os = new OrderService();
                os.AddOrder(order1);
                os.AddOrder(order2);
                os.AddOrder(order3);
                OrderExport2Xml(os);

                OrderService osnew = XmlImport2Order(); //Read data of order system from existing Xml configuration file
                //OrderService osnew = os;              //Use the data created manually

                Console.WriteLine("GetAllOrdersInIDAscendingOrder");
                List<Order> orders = osnew.QueryAllOrders();
                orders.Sort();
                foreach (Order order in orders)
                    Console.WriteLine(order.ToString());


                Console.WriteLine("GetAllOrdersInSumDecendingOrder");
                foreach (Order order in orders)
                {
                    order.CalculateSum();
                }
                
                foreach (Order order in orders.OrderByDescending(i => i.sum))
                {
                    Console.WriteLine(order.ToString());
                    Console.WriteLine("\tsum = "+order.sum.ToString());

                }


                Console.WriteLine("GetOrdersByCustomerName:'Customer2'");
                orders = osnew.QueryByCustomerName("Customer2");
                foreach (Order order in orders)
                    Console.WriteLine(order.ToString());

                Console.WriteLine("GetOrdersByGoodsName:'apple'");
                orders = osnew.QueryByGoodsName("apple");
                foreach (Order order in orders)
                    Console.WriteLine(order);
                
                Console.WriteLine("Remove order(id=2) and qurey all");
                osnew.RemoveOrder(2);
                osnew.QueryAllOrders().ForEach(
                    od => Console.WriteLine(od));


            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }



        }

    
    public static void OrderExport2Xml(OrderService os) {
            
            String path = String.Format("{0}\\test.xml", Environment.CurrentDirectory);
            XDocument xdoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));

            XElement root = new XElement("OrderService");
            foreach(Order o in os.QueryAllOrders())
            {
                XElement order = new XElement("Order");
                order.SetElementValue("OrderId", o.Id);
                XElement customer = new XElement("Customer");
                customer.SetElementValue("CustomerId", o.Customer.Id);
                customer.SetElementValue("CustomerName", o.Customer.Name);
                order.Add(customer);
                //order.SetElementValue("Customer", o.Customer);
                foreach (OrderDetail od in o.Details)
                {
                    XElement orderdetail = new XElement("OrderDetail");
                    orderdetail.SetElementValue("OrderDetailId", od.Id);
                    XElement good = new XElement("Good");
                    good.SetElementValue("GoodId", od.Goods.Id);
                    good.SetElementValue("GoodName", od.Goods.Name);
                    good.SetElementValue("GoodValue", od.Goods.Price);
                    orderdetail.Add(good);
                    orderdetail.SetElementValue("OrderDetailQuantity", od.Quantity);
                    //orderdetail.SetElementValue("Goods", od.Goods);
                    order.Add(orderdetail);

                }
                root.Add(order);
            }

            xdoc.Add(root);
            xdoc.Save(path);
            return;
        }

        public static OrderService XmlImport2Order()
        {
            OrderService os = new OrderService();
            XDocument document = XDocument.Load("input.xml");
           
            foreach (XElement order in document.Element("OrderService").Elements("Order"))
            {
                Order o = new Order(uint.Parse(order.Element("OrderId").Value), new Customer(uint.Parse(order.Element("Customer").Element("CustomerId").Value), order.Element("Customer").Element("CustomerName").Value));
                foreach (XElement orderdetail in order.Elements("OrderDetail"))
                {
                    OrderDetail od = new OrderDetail(uint.Parse(orderdetail.Element("OrderDetailId").Value), new Goods(uint.Parse(orderdetail.Element("Good").Element("GoodId").Value), orderdetail.Element("Good").Element("GoodName").Value, double.Parse(orderdetail.Element("Good").Element("GoodValue").Value)), uint.Parse(orderdetail.Element("OrderDetailQuantity").Value));
                    o.AddDetails(od);
                }
                os.AddOrder(o);
            }



            return os;
        }
            
    }
}
