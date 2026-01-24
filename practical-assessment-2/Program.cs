//Author: Kayed Mankal

namespace practical_assessment_2;

// This class holds the main entry point for the application
// The main method creates a view and a controller object, passing the view object into the controller and then runs methods from the controller.
// [1] “W3schools.com,” W3Schools Online Web Tutorials, https://www.w3schools.com/cs/cs_switch.php
// [2] “W3schools.com,” W3Schools Online Web Tutorials, https://www.w3schools.com/cs/cs_user_input.php
// [3] Dotnet-Bot, “Int32.TryParse method (system),” (System) | Microsoft Learn, https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=net-10.0
// [4] “ASP.NET MVC Pattern: .NET,” Microsoft, https://dotnet.microsoft.com/en-us/apps/aspnet/mvc
public class Program
{
    public static void Main(string[] args)
    {
        View view = new View();
        Controller controller = new Controller(view);
        controller.Run();
    }
}