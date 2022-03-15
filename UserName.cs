using System;

namespace EJK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zehmet olmasa Username daxil edin");
            string username = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa age daxil edin");
            int age=Convert.ToInt32(Console.ReadLine());
            if(age<0)
            {
                Console.WriteLine("Age menfi ola bilmez");
                return;
            }
            Console.WriteLine("Zehmet olmasa Password daxil edin");
            string password = Console.ReadLine();
            if(password.Length<8)
            {
                Console.WriteLine("password 8 den kicik ola bilmez");
                return ;
            }
        }
    }
    class User
    { 
        public string Username { get; set; }
        public int  Age { get; set; }  
        public string Password { get; set; }
        public User(string username,string password)
        {
            Username = username;
            Password = password;
        }
    }

}
