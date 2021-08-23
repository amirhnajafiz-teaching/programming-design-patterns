using System;

namespace Factory
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            IRobot driver = Factory.Build("driver");
            IRobot warrior1 = Factory.Build("warrior");
            IRobot warrior2 = Factory.Build("warrior");
            
            Console.WriteLine(driver.GetInfo());
            Console.WriteLine(warrior1.GetInfo());
        }
    }
}