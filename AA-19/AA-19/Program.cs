using System;

namespace AA_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1--Share status");
            Console.WriteLine("2--Get all statuses");
            Console.WriteLine("3--Get status by id");
            Console.WriteLine("4--Filter status by date");
            Console.WriteLine("0--Quit");
            Console.WriteLine("Zehmet olmasa deyer daxil edin");
            int n= Convert.ToInt32(Console.ReadLine());
            if (n==1)
            {
                Console.WriteLine("Share status");
            }
            else if (n==2)
            {
                Console.WriteLine("Get all statuses");
            }
            else if (n==3)
            {
                Console.WriteLine("Get status by id");
            }
            else if (n==4)
            {
                Console.WriteLine("Filter status by date");
            }
            else if (n==0)
            {
                Console.WriteLine("Quit");
            }
            else
            {
                
            }



        }
    }
}
