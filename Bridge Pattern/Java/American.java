public class American implements Type {
    @Override
    public void information() {
        System.out.println(this.getClass().getName().toLowerCase());
    }
}
