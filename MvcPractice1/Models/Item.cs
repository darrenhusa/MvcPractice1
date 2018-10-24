﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPractice1.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Description { get; set; }
        public int UnitsOnHand { get; set; }
        public decimal Cost { get; set; }
        public decimal SellingPrice { get; set; }
    }
}