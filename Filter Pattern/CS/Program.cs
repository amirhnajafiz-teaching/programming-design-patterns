using System;
using System.Collections.Generic;

namespace Filter
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var items = new List<Item>
            {
                new Item("2217", "L.A"),
                new Item("2218", "L.A"),
                new Item("2219", "L.A"),
                new Item("2217", "N.Y"),
                new Item("2218", "N.Y"),
                new Item("2219", "N.Y"),
                new Item("2217", "Miami"),
                new Item("2218", "Miami")
            };

            var filter1 = new CityAndCodeFilter("L.A", "2217").MatchItems(items);
            var filter2 = new CityOrCodeFilter("N.Y", "2219").MatchItems(items);

            foreach (var item in filter1)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("--------------");
            
            foreach (var item in filter2)
            {
                Console.WriteLine(item);
            }
        }
    }
}