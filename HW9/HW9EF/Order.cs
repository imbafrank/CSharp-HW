using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9EF
{
    public class Order
    {
        [Key]
        public String Id { get; set; }
        public String Customer { get; set; }
        //public DateTime CreateTime { get; set; }
        public List<OrderDetail> Details { get; set; }
        public Order()
        {
            Details = new List<OrderDetail>();
        }
        public Order(String Id, String Customer)
        {
            this.Id = Id;
            this.Customer = Customer;
            Details = new List<OrderDetail>();
        }
        public Order(String Id, String Customer, List<OrderDetail> odlist)
        {
            this.Id = Id;
            this.Customer = Customer;
            Details = odlist;
        }
        public void AddDetails(OrderDetail orderDetail)
        {
            if (this.Details.Contains(orderDetail))
            {
                throw new Exception($"orderDetail of the goods ({orderDetail.Goods}) exists in order {Id}");
            }
            Details.Add(orderDetail);
        }
    }

}
