using System;
using System.IO;

namespace WYU_980
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\Users\Administrator\Desktop\Files");
            if (!Directory.Exists(@"C:\Users\Administrator\Desktop\Files\Database.json"))
            {
                File.Create(@"C:\Users\Administrator\Desktop\Files\Database.json");
            }

            Console.WriteLine("Bir deyer daxil edin");
            Console.WriteLine("1. Add employee");
            Console.WriteLine("2. Get employee by id");
            Console.WriteLine("3. Remove employee");
            Console.WriteLine("0. Quit");

            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("Id = 3; Name = Mushfig; Salary = 6000");
            }
            else if (n == 2)
            {
                Console.WriteLine("ID daxil edin");
                int id = Convert.ToInt32(Console.ReadLine());
                using (StreamReader sw1 = new StreamReader(@"C:\Users\Administrator\Desktop\Files\Database.json", true))
                {
                    Console.WriteLine(sw1.ReadToEnd());
                }
               
            }
            else if (n == 3)
            {
                Console.WriteLine("ID daxil edin");
                int id = Convert.ToInt32(Console.ReadLine());
                StreamReader sw1 = new StreamReader(@"C:\Users\Administrator\Desktop\Files\Database.json", true);
                string result = sw1.ReadToEnd();
                Console.WriteLine(result);
            }
            else if (n == 0)
            {

            }



        }
    }
}
