namespace DecoratorPattern
{
    public abstract class Car
    {
        private readonly string _model;

        protected Car(string model)
        {
            this._model = model;
        }

        public string GetModel()
        {
            return this._model;
        }
    }
}