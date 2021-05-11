public class App {

    public static void main(String[] args) {
	    Factory factory = new Factory();
	    Device myMobile = factory.getDevice("mobile", 15L);
        Device myComputer = factory.getDevice("computer", 156L);
        Device myTV = factory.getDevice("tv", 165L);
    }
}
