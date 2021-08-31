namespace CompositePattern
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var city = new City();
            city.AddCitizen(new Man("Amir", 20));
            city.AddCitizen(new Women("Monica", 21));
            city.AddCitizen(new Man("Chandler", 45));
            
            city.GetFull();
        }
    }
}