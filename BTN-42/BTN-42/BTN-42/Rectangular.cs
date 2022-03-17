using System;
using System.Collections.Generic;
using System.Text;

namespace BTN_42.BTN_42
{
    internal class Rectangular:Figure
    {
        public int width { get; set; }  
        public int length { get; set; }

        public Rectangular(int width,int length)
        {
            this.width = width;
            this.length = length;
        }

        public override void CalcArea()
        {
            Console.WriteLine("Rectangular-in CalcArea methodu");
        }
    }
}
