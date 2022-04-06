using System;
using System.Collections.Generic;
using System.Text;
using static Utils_class_library.Enums.Enums;

namespace Entities_class_library
{
    internal class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Platform Platform { get; set; }

        public double Price { get; set; }
        public int DiscountPercent { get; set; }
        public string Publisher { get; set; }
        public bool IsDeleted { get; set; }
        public void ShowInfo()
        {

        }
        public double GetDiscountedPrice()
        {
            return Price - Price * (DiscountPercent / 100);
        }
        public Game(string name, Platform platform, double price)
        {
            Name = name;
            Platform = platform;
            Price = price;
        }
    }
}
