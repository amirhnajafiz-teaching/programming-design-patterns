public class Main {
    public static void main(String[] args)
    {
        Media myMusic = AbstractFactory.AUDIO.getProduct("music");
        Media myMovie = AbstractFactory.VISUAL.getProduct("movie");
        System.out.println(myMusic.getModel());
        System.out.println(myMovie.getModel());
    }
}
