using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {

    /// <summary>
    /// Order class : all orderDetails
    /// to record each goods and its quantity in this ordering
    /// </summary>
    class Order:IComparable{

        private List<OrderDetail> details=new List<OrderDetail>();

        /// <summary>
        /// Order constructor
        /// </summary>
        /// <param name="orderId">order id</param>
        /// <param name="customer">who orders goods</param>
        public Order(uint orderId, Customer customer) {
            Id = orderId;
            Customer = customer;
            sum = 0;
        }

        /// <summary>
        /// order id
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// the man who orders goods
        /// </summary>
        public Customer Customer { get; set; }
        public double sum { get; set; }

        public List<OrderDetail> Details {
            get =>this.details; }

        public double CalculateSum()
        {

            

                
            foreach (OrderDetail od in Details)
            {
                sum += od.Goods.Price * od.Quantity;
            }




            return sum;

            
        }

        /// <summary>
        /// add new orderDetail to order
        /// </summary>
        /// <param name="orderDetail">the new orderDetail which will be added</param>
        public void AddDetails(OrderDetail orderDetail) {
            if (this.Details.Contains(orderDetail))  {
                throw new Exception($"orderDetails-{orderDetail.Id} is already existed!");
            }
            details.Add(orderDetail);
        }

        /// <summary>
        /// remove orderDetail by orderDetailId from order
        /// </summary>
        /// <param name="orderDetailId">id of the orderDetail which will be removed</param>
        public void RemoveDetails(uint orderDetailId) {
            details.RemoveAll(d =>d.Id==orderDetailId);
        }

        /// <summary>
        /// override ToString
        /// </summary>
        /// <returns>string:message of the Order object</returns>
        public override string ToString() {
            String result = $"orderId:{Id}, customer:({Customer})";
            details.ForEach(detail => result += "\n\t" + detail);
            return result;
        }

        // override object.Equals
        public override bool Equals(object obj) {
            if (obj != null && GetType() == obj.GetType())
            {
                Order oobj = (Order)obj;
                if (oobj.Id == this.Id)
                {
                    if (oobj.Customer == this.Customer)
                        return true;
                    else
                        throw new Exception("Error, same order Id with different customer!");
                }
            }

            return false;       
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            int hashcode = 0;
            foreach (System.Reflection.PropertyInfo info in GetType().GetProperties())
                hashcode += info.GetHashCode();

            return hashcode;
        }

        public int CompareTo(object obj)
        {
            if(GetType() == obj.GetType())
            {
                Order oobj = (Order)obj;
                return Id.CompareTo(oobj.Id);
            }
            return 1;
        }


    }
}
