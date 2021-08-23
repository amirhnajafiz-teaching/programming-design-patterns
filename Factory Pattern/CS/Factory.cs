namespace Factory
{
    public class Factory
    {
        public static IRobot Build(string type)
        {
            switch (type)
            {
                case "warrior":
                    return new WarBot();
                case "driver":
                    return new DriverBot();
                default:
                    return null;
            }
        }
    }
}