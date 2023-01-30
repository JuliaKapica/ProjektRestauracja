﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Bill
    {
        public Order Order { get; set; }
        public double TotalPrice { get; set; }
        public double PaidAmount { get; set; }
        public double Change { get; set; }

        public Bill(Order order, double paidAmount)
        {
            Order = order;
            TotalPrice = order.TotalPrice;
            PaidAmount = paidAmount;
            Change = paidAmount - TotalPrice;
        }
        
    }
}
