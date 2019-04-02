using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {

  /// <summary>
  /// OrderDetail class : a entry of an order object
  /// to record the goods and its quantity
  /// </summary>
  class OrderDetail {

    /// <summary>
    /// OrderDetail constructor
    /// </summary>
    /// <param name="id">orderDetail's id</param>
    /// <param name="goods">orderDetail's goods</param>
    /// <param name="quantity">goods quantity</param>
    public OrderDetail(uint id, Goods goods, uint quantity) {
      this.Id = id;
      this.Goods = goods;
      this.Quantity = quantity;
    }
    /// <summary>
    /// OrderDetail's id
    /// </summary>
    public uint Id { get; set; }

    /// <summary>
    /// orderDetail's goods
    /// </summary>
    public Goods Goods { get; set; }

    /// <summary>
    /// goods quantity
    /// </summary>
    public uint Quantity { get; set; }

    //public override bool Equals(object obj) {
    //  var detail = obj as OrderDetail;
    //  return detail != null &&
    //      Goods.Id == detail.Goods.Id &&
    //      Quantity == detail.Quantity;
    //}

    //public override int GetHashCode() {
    //  var hashCode = 1522631281;
    //  hashCode = hashCode * -1521134295 + Goods.Name.GetHashCode();
    //  hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
    //  return hashCode;
    //}

    /// <summary>
    /// override ToString
    /// </summary>
    /// <returns>string:message of the OrderDetail object</returns>
    public override string ToString() {
      string result = "";
      result += $"orderDetailId:{Id}:  ";
      result += Goods + $", quantity:{Quantity}";
      return result;
    }

     //override object.Equals
    public override bool Equals(object obj)
    {
        if (obj != null && GetType() == obj.GetType())
        {
            OrderDetail odobj = (OrderDetail)obj;
            if (odobj.Id == this.Id)
            {
                if (odobj.Goods == this.Goods && odobj.Quantity == this.Quantity )
                    return true;
                else
                    throw new Exception("Error, same orderdetail Id with different content!");
            }
        }

        return false;
    }

     //override object.GetHashCode
    public override int GetHashCode()
    {
        int hashcode = 0;
        foreach (System.Reflection.PropertyInfo info in GetType().GetProperties())
            hashcode += info.GetHashCode();

        return hashcode;
    }



    }
}
