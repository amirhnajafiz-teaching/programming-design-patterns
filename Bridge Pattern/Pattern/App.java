public class App {
    public static void main(String[] args)
    {
        Model americanHardModel = new Hard(new American());
        Model britishSoftModel = new Soft(new British());
        americanHardModel.identify();
        britishSoftModel.identify();
    }
}
