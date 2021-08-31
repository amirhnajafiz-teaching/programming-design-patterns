using System;

namespace DecoratorPattern
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var bmw = new EuropianCar("BMW-x", "12GE-20", false, "Germany");
            var honda = new NormalCar("H-21", "10-JT-22");
            var fiat = new AmericanCar("O-9", "11-LA-22", true, "California");
            
            Console.WriteLine(bmw.GetInfo());
            Console.WriteLine(honda.GetInfo());
            Console.WriteLine(fiat.GetInfo());
        }
    }
}