import java.util.Date;

public class SingletonLogger
{
    // Eager initialization
    private static SingletonLogger instance;
    private final int ID;

    // Private constructor
    private SingletonLogger(int ID)
    {
        this.ID = ID;
    }

    public static SingletonLogger getInstance(int ID)
    {
        if (instance == null)
        {
            instance = new SingletonLogger(ID);
        }
        return instance;
    }

    public static SingletonLogger getInstance()
    {
        if (instance == null)
        {
            instance = new SingletonLogger(0);
        }
        return instance;
    }

    public void log()
    {
        Date date = new Date();
        System.out.println(this.ID + "|" + date.toString());
    }
}

