namespace Singleton
{
    public class Singleton
    {
        private Singleton(int init) {
            _code = init;
        }

        private static Singleton _instance = null;
        private readonly int _code;

        public int GetCode()
        {
            return _code;
        }

        public static Singleton GetInstance(int init)
        {
            return _instance ?? (_instance = new Singleton(init));
        }
    }
}