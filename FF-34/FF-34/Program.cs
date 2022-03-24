using System;

namespace FF_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celsius celsius = new Celsius(90);
            Kelvin kelvin = celsius;
            Console.WriteLine(kelvin.DegreeK);
            
        }
    }
    class Kelvin
    {
        public double DegreeK { get; set; }
        public Kelvin(double degree)
        {
        DegreeK = degree;
        }
    }

    class Celsius
    {
        public double DegreeC { get; set; }
        public Celsius(double degree)
        {
            DegreeC = degree;
        }
        public static implicit operator Kelvin(Celsius d)
        {
            return new Kelvin(d.DegreeC + 273);
        }
    }
}
