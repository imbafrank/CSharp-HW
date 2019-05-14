using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9EF
{
    public class OrderService
    {
        public void AddOrder(Order o)
        {
            using (var db = new Model1())
            {
                //if (o.Details != null)
                //    db.OrderDetail.AddRange(o.Details);
                //db.SaveChanges();

                db.Order.Add(o);
                db.SaveChanges();
            }
        }

        public void RemoveOrder(String oid)
        {
            using (var db = new Model1())
            {
                Order order = db.Order.Find(oid);
                db.Order.Remove(order);
                db.SaveChanges();
            }
        }

        public Order GetById(String oid)
        {
            return new Model1().Order.Find(oid);
        }

        public void Update(Order o)
        {
            using (var db = new Model1())
            {
                Order order = db.Order.Find(o.Id.ToString());
                db.Order.Remove(order);
                db.Order.Add(o);
                db.SaveChanges();
            }
        }

        public List<Order> QueryAll()
        {
            using (var db = new Model1())
            {
                List<Order> orderList = db.Order.ToList();
                Console.WriteLine(orderList[1].Id);

            }
            return new Model1().Order.ToList();

        }

        public List<Order> QueryByGoodsName(string goodsName)
        {
            //return new Model1().Order.Where(o => o.Details.Exists(od => od.Goods == goodsName)).ToList();
            return new Model1().Order.Where(o => o.Details.Where(od => od.Goods == goodsName).ToList().Count > 0).ToList();
        }

        public List<Order> QueryByCustomerName(string customerName)
        {
            return new Model1().Order.Where(o=>o.Customer==customerName).ToList();
        }
    }
}
