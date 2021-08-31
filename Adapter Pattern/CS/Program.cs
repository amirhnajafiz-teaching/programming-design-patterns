using System;

namespace AdapterPattern
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            TypeC typeC = new TypeC("11001100");
            TypeE typeE = new TypeE("24240024");
            TypeC adapter = new CToEAdapter("10101212");
            
            Console.WriteLine(typeC);
            Console.WriteLine(typeE);
            Console.WriteLine(adapter.ToggleTarget());
        }
    }
}