using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class OrderDetail
    {
        string itemname { get; }
        int itemnum { get; set; }

        public OrderDetail(string itemid, int itemnum)
        {
            this.itemnum = itemnum;
            this.itemname = itemname;
        }
    }

    
}
