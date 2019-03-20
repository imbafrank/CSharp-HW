using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class Order
    {
        public int orderid { get; }
        List<OrderDetail> item { get; set; }
        public string customername { get; }

        public Order()
        {

        }

        public Order(int orderid, string customername)
        {
            this.orderid = orderid;
            this.customername = customername;
            this.item = new List<OrderDetail>();
        }

        public void AddItem(OrderDetail od)
        {
            bool noexistenceflag = true;
            for (int i = 0; i < item.Count; i++)
            {
                if(od.itemname==item[i].itemname)
                {
                    noexistenceflag = false;
                    item[i].itemnum += od.itemnum;
                    Console.WriteLine("Number of item is added");
                }
            }

            if (noexistenceflag)
            {
                item.Add(od);
                Console.WriteLine("New item added");
            }
        }

        public void UpdateItem(string itemname, int itemnum)
        {
            bool noexistenceflag = true;
            for (int i = 0; i < item.Count; i++)
            {
                if (itemname == item[i].itemname)
                {
                    noexistenceflag = false;
                    item[i].itemnum=itemnum;
                    Console.WriteLine("Number of item is updated");
                }
            }

            if (noexistenceflag)
            {
                item.Add(new OrderDetail(itemname, itemnum));
                Console.WriteLine("No such item to update, new item is added");
            }
        }

        public void RemoveItem(string itemname)
        {
            bool noexistenceflag = true;
            for (int i = 0; i < item.Count; i++)
            {
                if (itemname == item[i].itemname)
                {
                    noexistenceflag = false;
                    item.RemoveAt(i);
                    Console.WriteLine("Item removed");
                }
            }

            if (noexistenceflag)
            {
                throw new Exception("No such item to remove!");
            }
        }
    }
}
