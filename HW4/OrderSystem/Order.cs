﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class Order
    {
        public int orderid { get; }
        List<OrderDetail> item;
        string custmername;

    }
}
