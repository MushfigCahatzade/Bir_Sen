using System;
using System.Collections.Generic;
using System.Text;

namespace BTN_42.BTN_42
{
    internal class Square:Figure
    {
        public int side;
        public Square(int Side)
        {
            side = Side;
        }

        public override void CalcArea()
        {
            Console.WriteLine("Square-in CalcArea methodu");
        }
    }
}
