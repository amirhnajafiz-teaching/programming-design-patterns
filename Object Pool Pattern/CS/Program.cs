using System;

namespace ObjectPool
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var pool = new Pool(1);

            var obj = pool.CheckIn("First");
            var newObj = pool.CheckIn("Second");
            
            Console.WriteLine(obj);
            Console.WriteLine(newObj);

            pool.CheckOut(obj);

            newObj = pool.CheckIn("New second");
            Console.WriteLine(newObj);
        }
    }
}