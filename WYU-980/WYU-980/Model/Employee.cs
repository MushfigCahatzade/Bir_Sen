using System;
using System.Collections.Generic;
using System.Text;

namespace WYU_980.Model
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public void ShowInfo()
        {
            int Id = 3;
            string Name = "Mushfig";
            double Salary = 6000;
        }
    }
}
