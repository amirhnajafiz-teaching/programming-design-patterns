using System;

namespace Builder
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var myObj = new IObject().SetCode(12).SetNullAble(false).SetId("25552X").SetMeta("Header:Location");
            var newObj = new IObject().SetNullAble(true).SetId("TT66").SetMeta("Empty space");
            
            Console.WriteLine(myObj);
            Console.WriteLine(newObj);
        }
    }
}