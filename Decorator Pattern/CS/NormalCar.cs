namespace DecoratorPattern
{
    public class NormalCar : Car
    {
        private readonly string _number;

        public NormalCar(string model, string number) : base(model)
        {
            this._number = number;
        }

        public string GetInfo()
        {
            return this._number;
        }
    }
}