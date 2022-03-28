using System;
using System.Collections.Generic;
using System.Text;

namespace DL_108.DL_108
{
    abstract class Product
    {
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }   
        public int Count { get; set; }


        public abstract void Sell();
        public abstract void ShowInfo();
    }
}
