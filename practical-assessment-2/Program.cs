namespace practical_assessment_2;

public class Program
{
    public static void Main(string[] args)
    {
        View view = new View();
        Controller controller = new Controller(view);
        controller.Run();
    }
}