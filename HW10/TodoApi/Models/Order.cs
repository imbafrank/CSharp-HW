using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApi.Models {
    public class Order {
        [Key]
        public String Id { get; set; }
        public String Customer { get; set; }

        public List<OrderDetail> Details { get; set; }

        public Order() {
            Details = new List<OrderDetail>();
        }

        public Order(string id, string customer, List<OrderDetail> details) {
            Id = id;
            Customer = customer;
            this.Details = details;



        }

            public Order(string id, string customer) {
            Id = id;
            Customer = customer;



        }
        


    }
}
