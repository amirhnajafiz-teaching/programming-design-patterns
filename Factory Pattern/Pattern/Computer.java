public class Computer implements Device {
    private final long ID;

    public Computer(long ID)
    {
        this.ID = ID;
    }

    @Override
    public String aboutDevice() {
        return ID + " | simple computer";
    }
}
