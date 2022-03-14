using System;
using System.Collections.Generic;
using System.Text;

namespace task_6.Models
{
    internal class Car : Vehicle
    {
        public string brand;
        public string model;
        public float fuelCapacity;
        public float fuelFor1Km;
        public float currentFuel;

        public Car(float currentFuel, string color, ref string brand, ref string model, ref float fuelCapacity, ref float fuelFor1Km, ref int year) : base(color, year)
        {
            this.brand = brand;
            this.model = model;
            this.fuelCapacity = fuelCapacity;
            this.fuelFor1Km = fuelFor1Km;
            this.currentFuel = currentFuel;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Brend: {brand} {Environment.NewLine}" +
                $"Model: {model} {Environment.NewLine}" +
                $"Rəng: {color} {Environment.NewLine}" +
                $"İl: {year} {Environment.NewLine}" +
                $"Yanacaq tutumu: {fuelCapacity} L {Environment.NewLine}" +
                $"1Km üçün yanacaq: {fuelFor1Km} L {Environment.NewLine}" +
                $"Cari yanacaq: {currentFuel} L");
        }
        public void Drive(float way)
        {
            float fuelConsumption = way * fuelFor1Km;
            if (fuelConsumption <= currentFuel)
            {
                Console.WriteLine(currentFuel = currentFuel - fuelConsumption);
            } else
            {
                Console.WriteLine("Yanacaq çatmır");
            }
        }
    }
}