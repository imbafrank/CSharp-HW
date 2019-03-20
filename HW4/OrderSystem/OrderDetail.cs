using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class OrderDetail
    {
        public string itemname { get; }
        public int itemnum { get; set; }

        public OrderDetail(string itemname, int itemnum)
        {
            this.itemnum = itemnum;
            this.itemname = itemname;
        }
    }

    
}
