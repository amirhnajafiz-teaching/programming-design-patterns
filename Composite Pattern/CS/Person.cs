namespace CompositePattern
{
    public abstract class Person
    {
        protected string Name;
        protected int Age;
        protected string Gender;
        
        public string GetName()
        {
            return this.Name;
        }

        public int GetAge()
        {
            return this.Age;
        }

        protected string GetGender()
        {
            return this.Gender;
        }

        public abstract string GetInfo();
    }
}