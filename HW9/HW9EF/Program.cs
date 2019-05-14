using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9EF
{
    public class Program
    {
        static void Main(string[] args)
        {
            OrderDetail orderDetail = new OrderDetail("5", "3", 3, 4);
            //List<OrderDetail> odList = new List<OrderDetail>();
            //odList.Add(orderDetail);
            Order order = new Order("7", "2");//, new List<OrderDetail>());
            OrderService os = new OrderService();
            //order.AddDetails(orderDetail);
            os.AddOrder(order);
            //os.RemoveOrder(3);
            //os.Update(order);
            //os.QueryAll();
            //Console.WriteLine(os.QueryByGoodsName("3")[0].Id);
            //Console.WriteLine(os.QueryByCustomerName("0").Count);

            //Console.WriteLine(os.QueryByCustomerName("2")[0].Id);
        }
    }
}
