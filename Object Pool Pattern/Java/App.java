public class App {
    public static void main(String[] args)
    {
        ToolPool toolPool = new ToolPool();

        Tool firstTool = (Tool) toolPool.create();
        Tool secondTool = (Tool) toolPool.create();

        toolPool.checkOut(firstTool);
        toolPool.checkOut(secondTool);

        Tool thirdTool = (Tool) toolPool.checkIn();
        System.out.print(thirdTool);
    }
}
