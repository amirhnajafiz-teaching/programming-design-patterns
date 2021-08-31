namespace DecoratorPattern
{
    public abstract class Decorator : NormalCar
    {
        private readonly bool _registered;
        
        protected Decorator(string model, string number, bool registered) : base(model, number)
        {
            _registered = registered;
        }

        public bool IsRegistered()
        {
            return this._registered;
        }
    }
}