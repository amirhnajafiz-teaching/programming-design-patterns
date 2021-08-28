import java.util.concurrent.ThreadLocalRandom;

public class ToolPool extends ObjectPool {

    @Override
    public Object create() {
        int toolId = ThreadLocalRandom.current().nextInt();
        return new Tool(toolId);
    }
}
