namespace DecoratorPattern
{
    public class AmericanCar : Decorator
    {
        private readonly string _state;
        
        public AmericanCar(string model, string number, bool registered, string state) : base(model, number, registered)
        {
            _state = state;
        }

        public new string GetInfo()
        {
            return base.GetInfo() + " " + _state;
        }
    }
}