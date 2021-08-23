namespace ABFact
{
    public interface IFactory
    {
        IDevice Build(string type);
    }
}