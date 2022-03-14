using System;
using System.Collections.Generic;
using System.Text;

namespace task_6.Models
{
    internal class Vehicle
    {
        public string color;
        public int year = 2010;

        public Vehicle(string color, int year)
        {
            this.color = color;
            this.year = year;
        }
    }
}
