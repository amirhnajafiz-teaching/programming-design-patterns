public class Soft extends Model {

    private Type type;

    public Soft(Type type)
    {
        this.type = type;
    }

    @Override
    public void identify() {
        type.information();
    }
}
