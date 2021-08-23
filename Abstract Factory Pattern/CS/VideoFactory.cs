namespace ABFact
{
    public class VideoFactory : IFactory
    {
        public IDevice Build(string type)
        {
            switch (type)
            {
                case "mp4":
                    return new Mp4();
                default:
                    return null;
            }
        }
    }
}