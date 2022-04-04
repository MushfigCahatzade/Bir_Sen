using ConsoleApp35.App_35;
using System;

namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department omer = new Department("Yusifov");            
            omer.ShowInfo();
            Department musviq = new Department("Cahatzade");
            musviq.ShowInfo();
        }
    }
}
