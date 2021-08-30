using System;

namespace BridgePattern
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var aCmodel = new Amodel(new Ctype());
            var bDmodel = new Bmodel(new Dtype());
            
            Console.WriteLine(aCmodel.ClassInfo());
            Console.WriteLine(bDmodel.ClassInfo());
        }
    }
}