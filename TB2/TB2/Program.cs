using System;

namespace TB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zehmet olmasa Name daxil edin");
            string name=Console.ReadLine();
            if (name.Length<3||name.Length>30)
            {
                Console.WriteLine("Name minimum 3 maxsimum 30 simvoldan ibaret ola biler");
                return;
            }
            int a = name.Length;
            string b = name.Substring(0, name.Length-(a-1)).ToUpper() + name.Substring(1);
            Console.WriteLine(b);
            Console.WriteLine("Zehmet olmasa Surname daxil edin");
            string Surname = Console.ReadLine();
            if (Surname.Length<3||Surname.Length>35)
            {
                Console.WriteLine("Surname minimum 3 maxsimum 35 simvoldan ibaret ola biler");
                return ;
            }
            int c = Surname.Length;
            string d = Surname.Substring(0, Surname.Length - (a - 1)).ToUpper() + Surname.Substring(1);
            Console.WriteLine(d);
            Console.WriteLine("Zehmet olmasa Age daxil edin");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zehmet olmasa Point daxil edin");
            int point=Convert.ToInt32(Console.ReadLine());
            if (point < 0 || point > 100)
            {
                Console.WriteLine("Point 0 dan kicik ve 100 den boyuk ola bilmez");
                return;
            }
            

        }

    }
}
