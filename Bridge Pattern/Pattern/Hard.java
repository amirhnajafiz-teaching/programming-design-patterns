public class Hard extends Model {

    private Type type;

    public Hard(Type type)
    {
        this.type = type;
    }

    @Override
    public void identify() {
        type.information();
    }
}
