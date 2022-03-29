using System;
using System.Collections.Generic;
using System.Text;

namespace LN_40.Models
{
    internal class Medicine
    {
        private static int id = 0;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public bool IsDeleted { get; set; }

        public Medicine(string name, double price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
            Id = ++id;
        }

        public void Sell()
        {

        }


        public void ShowInfo()
        {
            Console.WriteLine("----------");
            Console.WriteLine(Id);
            Console.WriteLine(Name);
            Console.WriteLine(Price);
            Console.WriteLine("----------");

        }
    }
}
