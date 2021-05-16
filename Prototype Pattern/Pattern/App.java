import java.util.ArrayList;
import java.util.List;

public class App {
    public static void main(String[] args)
    {
        Component component = new Component(100, "Hello");

        List<String> msg = new ArrayList<>();
        msg.add("Hello");
        msg.add("World");
        msg.add("Java");

        BigObject obj = new BigObject(12L, msg, component);
        BigObject obj2 = obj.clone();
        obj2.clear();
    }
}
