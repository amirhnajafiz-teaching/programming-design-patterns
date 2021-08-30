public class British implements Type {
    @Override
    public void information() {
        System.out.println("101" + this.getClass().getName().toLowerCase());
    }
}
