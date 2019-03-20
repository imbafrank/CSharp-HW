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
            orderlist.Add(new Order(oid, cid));
        }

        public void DeleteOrder(int oid)
        {
            for (int i = 0; i<orderlist.Count; i++)
            {

                if (orderlist[i].Getoid() == oid)
                    orderlist.RemoveAt(i);
                else
                    throw new Exception("No such order!");

               
            }

            
        }


        public List<Order> GetByCname(string cname)
        {
            return orderlist;
        }
    }
}
