using System;

namespace Singleton
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var singleton = Singleton.GetInstance(12);
            Console.WriteLine(singleton.GetCode());

            var obj = Singleton.GetInstance(24);
            Console.WriteLine(obj.GetCode());
        }
    }
}