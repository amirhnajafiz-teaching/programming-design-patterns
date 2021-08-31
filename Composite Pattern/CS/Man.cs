namespace CompositePattern
{
    public class Man : Person
    {
        public Man(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = "Male";
        }
        
        public override string GetInfo()
        {
            return "This is a " + this.GetGender();
        }
    }
}