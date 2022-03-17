using BTN_42.BTN_42;
using System;

namespace BTN_42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1---Square");
            Console.WriteLine("2---Rectangular");
            Console.WriteLine("0.Quit");
            Console.WriteLine("Salam zehmet olmasa reqem daxil edin");


            int num = Convert.ToInt32(Console.ReadLine());


            switch (num)
            {
                case 1:
                    Console.WriteLine("Zehmet olmasa Side daxil edin");
                    int side = Convert.ToInt32(Console.ReadLine());
                    if (side <= 0)
                    {
                        Console.WriteLine("Side sifir ve ya menfi ola bilmez");
                        return;
                    }
                    Console.WriteLine("Square " + side);
                    break;
                case 2:
                    Console.WriteLine("Zehmet olmasa Width ve Length daxil edin");
                    int width = Convert.ToInt32(Console.ReadLine());
                    int length = Convert.ToInt32(Console.ReadLine());
                    int sahe = width * length;

                    if (width <= 0 || length <= 0)
                    {
                        Console.WriteLine("Width ve Length sifir ve ya menfi ola bilmez");
                        return;
                    }
                    Console.WriteLine("Rectangular " + sahe);

                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("not found");
                    break;
            }


            }
    }
}
