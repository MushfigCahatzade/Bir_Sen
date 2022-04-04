using System;
using System.Threading;

namespace ConsoleApp36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Loop1);
            Thread thread2 = new Thread(Loop2);
            thread1.Start();
            thread2.Start();
            Console.WriteLine("Hello Word");
            thread1.Join();
            thread2.Join();

            Loop1();
            Loop2();
        }
        static void Loop1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Loop1 {i}");
            }
        }
        static void Loop2()
        {
            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine($"Loop2 {i}");
            }
        }

    }
}
