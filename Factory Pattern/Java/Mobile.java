public class Mobile implements Device {
    private final long ID;

    public Mobile(long ID)
    {
        this.ID = ID;
    }

    @Override
    public String aboutDevice() {
        return ID + " | simple mobile";
    }
}
