using System;
using task_6.Models;

namespace task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string model = "Panamera", brand = "Porsche";
            float fuelCapacity = 100, fuelFor1Km = 16;
            int year = 2010;

            Car car = new Car(45, "Qara", ref model, ref brand, ref fuelCapacity, ref fuelFor1Km, ref year);
            //car.ShowInfo();

            car.Drive(2);
        }
    }
}
