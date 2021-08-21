public class TV implements Device {
    private final long ID;

    public TV(long ID)
    {
        this.ID = ID;
    }

    @Override
    public String aboutDevice() {
        return ID + " | simple TV";
    }
}
