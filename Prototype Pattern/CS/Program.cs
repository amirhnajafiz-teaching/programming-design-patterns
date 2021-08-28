using System;

namespace Prototype
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var obj = new BigObject(20, "First");
            var newObj = obj.Copy().ResetWith("Second");
            
            Console.WriteLine(obj);
            Console.WriteLine(newObj);
        }
    }
}