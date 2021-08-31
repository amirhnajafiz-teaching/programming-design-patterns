namespace CompositePattern
{
    public class Women : Person
    {
        public Women(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = "Female";
        }
        
        public override string GetInfo()
        {
            return "This is a " + this.GetGender();
        }
    }
}