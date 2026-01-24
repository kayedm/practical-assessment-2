//Author: Kayed Mankal

namespace practical_assessment_2;

// This class holds the method that the user will interact with. It contains a method that displays options,
// and gets input from the user. A method to show a custom message to the user, and a method get and return user input. 
// [1] “W3schools.com,” W3Schools Online Web Tutorials, https://www.w3schools.com/cs/cs_switch.php
// [2] “W3schools.com,” W3Schools Online Web Tutorials, https://www.w3schools.com/cs/cs_user_input.php
// [3] Dotnet-Bot, “Int32.TryParse method (system),” (System) | Microsoft Learn, https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=net-10.0
// [4] “ASP.NET MVC Pattern: .NET,” Microsoft, https://dotnet.microsoft.com/en-us/apps/aspnet/mvc
public class View {
    
    // This method displays a menu to the user, and returns a user input
    public int OptionsMenu()
    {
        Console.WriteLine("Pick an option:");
        Console.WriteLine("1) Write file");
        Console.WriteLine("2) Read file");
        Console.WriteLine("3) Exit");
        Console.WriteLine("Written by Kayed Mankal");
        
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int option))
        {
            return option;
        }

        return 0;

    }
    
    // This method displays a message to the user
    public void ShowMessage(String message)
    {
        Console.WriteLine(message);
    } 
    
    // This method returns user input 
    public string UserInput()
    {
        return Console.ReadLine() ?? "";
    }
}