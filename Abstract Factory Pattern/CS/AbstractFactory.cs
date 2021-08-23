namespace ABFact
{
    public class AbstractFactory
    {
        public static IFactory Audio = new AudioFactory();
        public static IFactory Video = new VideoFactory();
    }
}