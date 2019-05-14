using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9EF
{
    public class OrderDetail
    {
        [Key]
        public string Id { get; set; }
        public string Goods { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public OrderDetail()
        {
        }
        public OrderDetail(string Id, string Goods, double Price, int Quantity)
        {
            this.Id = Id;
            this.Goods = Goods;
            this.Price = Price;
            this.Quantity = Quantity;
        }
    }
}
