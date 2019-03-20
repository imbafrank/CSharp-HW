using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class Order
    {
        int orderid { get; }
        List<OrderDetail> item { get; set; }
        string customername { get; }

        public Order(int orderid, string customername)
        {
            this.orderid = orderid;
            this.customername = customername;
        }

        public int Getoid()
        {
            return orderid;
        }
    }
}
