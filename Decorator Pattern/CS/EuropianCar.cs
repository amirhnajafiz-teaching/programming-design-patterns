namespace DecoratorPattern
{
    public class EuropianCar : Decorator
    {
        private string _country;
        
        public EuropianCar(string model, string number, bool registered, string country) : base(model, number, registered)
        {
            _country = country;
        }

        public new string GetInfo()
        {
            return base.GetInfo() + " " + _country;
        }
    }
}