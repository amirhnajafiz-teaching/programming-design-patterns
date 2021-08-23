namespace ABFact
{
    public class AudioFactory : IFactory
    {
        public IDevice Build(string type)
        {
            switch (type)
            {
                case "mp3":
                    return new Mp3();
                default:
                    return null;
            }
        }
    }
}