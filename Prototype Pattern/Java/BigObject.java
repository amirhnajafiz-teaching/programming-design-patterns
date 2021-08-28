import java.util.List;

public class BigObject {
    private long id;
    private List<String> texts;
    private Component component;

    public BigObject(long id, List<String> texts, Component component) {
        this.id = id;
        this.texts = texts;
        this.component = component;
    }

    public void setId(long id) {
        this.id = id;
    }

    public void setTexts(List<String> texts) {
        this.texts = texts;
    }

    public void setComponent(Component component) {
        this.component = component;
    }

    public long getId() {
        return id;
    }

    public List<String> getTexts() {
        return texts;
    }

    public Component getComponent() {
        return component;
    }

    public BigObject clone()
    {
        try {
            return  (BigObject) super.clone();
        } catch (CloneNotSupportedException e) {
            e.printStackTrace();
            return null;
        }
    }

    public void clear()
    {
        this.id = 0L;
        this.texts = null;
        this.component = null;
    }
}
