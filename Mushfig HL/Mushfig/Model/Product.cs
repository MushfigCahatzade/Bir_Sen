﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mushfig.Model
{
    internal class Product
    {    
        public int No { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

        public Product(int no,string name,double price)
        {
            No = no;
            Name = name;
            Price = price;
        }
    }
}
