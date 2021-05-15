public class App {
    public static void main(String[] args)
    {
        SingletonLogger logger = SingletonLogger.getInstance(12009);
        logger.log();
        SingletonLogger otherLogger = SingletonLogger.getInstance();
        otherLogger.log();
    }
}
