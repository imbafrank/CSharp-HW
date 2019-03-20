using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class OrderService
    {
        private List<Order> orderlist;

        public OrderService()
        {
            orderlist = new List<Order>();
        }

        public void AddOrder(int oid, string cid)
        {
            bool noexistenceflag = true;
            for (int i = 0; i < orderlist.Count; i++)
            {

                if (orderlist[i].orderid == oid)
                {
                    noexistenceflag = false;
                    if (orderlist[i].customername == cid)
                    {
                        Console.WriteLine("Order already exists!");
                    }
                    else
                    {
                        throw new Exception("Order ID and customer's don't match!");
                    }
                }
            }

            if(noexistenceflag)
            {
                orderlist.Add(new Order(oid, cid));
                Console.WriteLine("Order successfully added");
            }

        }

        public void RemoveOrder(int oid)
        {
            for (int i = 0; i<orderlist.Count; i++)
            {

                if (orderlist[i].orderid == oid)
                {
                    orderlist.RemoveAt(i);
                    Console.WriteLine("Order successfully removed");
                }
                else
                    throw new Exception("No such order to remove!");
               
            }
        }


        public List<Order> GetByCname(string cname)
        {
            List<Order> demandorderlist = new List<Order>();
            Console.WriteLine("No\tOid\tCname");
            for (int i = 0; i < orderlist.Count; i++)
            {
                if (orderlist[i].customername == cname)
                {
                    demandorderlist.Add(orderlist[i]);
                    Console.WriteLine(demandorderlist.Count+"\t"+orderlist[i].orderid + "\t" + cname);
                }
            }

            if (demandorderlist.Count == 0)
                Console.WriteLine("No result");
            else if (demandorderlist.Count == 1) 
                Console.WriteLine("1 result has been found");
            else
                Console.WriteLine("{0} results have been found", demandorderlist.Count);
      
                return demandorderlist;
        }
    }
}
