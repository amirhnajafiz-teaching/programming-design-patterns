public class Factory {
    public Device getDevice(String type, long ID)
    {
        switch (type) {
            case "computer":
                return new Computer(ID);
            case "mobile":
                return new Mobile(ID);
            case "tv":
                return new TV(ID);
            default:
                return null;
        }
    }
}
