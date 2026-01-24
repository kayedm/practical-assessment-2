//Author: Kayed Mankal

namespace practical_assessment_2;

// This class is responsible for the logic of the program and runs methods from the view. 
// [1] “W3schools.com,” W3Schools Online Web Tutorials, https://www.w3schools.com/cs/cs_switch.php
// [2] “W3schools.com,” W3Schools Online Web Tutorials, https://www.w3schools.com/cs/cs_user_input.php
// [3] Dotnet-Bot, “Int32.TryParse method (system),” (System) | Microsoft Learn, https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=net-10.0
// [4] “ASP.NET MVC Pattern: .NET,” Microsoft, https://dotnet.microsoft.com/en-us/apps/aspnet/mvc
public class Controller {

    private View _view;
    
    public Controller(View view)
    {
        this._view = view;
    }

    // This method displays a menu from the view, and runs method bases on the users choice
    public void Run()
    {
        bool running =  true;
        
        while (running)
        {
            int choice = _view.OptionsMenu();
            
            switch (choice)
            {
                case 1: 
                    WriteToFile();
                    break;
                case 2:
                    ReadFile();
                    break;
                case 3:
                    _view.ShowMessage("Stopping program");
                    running = false;
                    break;
                default:
                    _view.ShowMessage("Invalid option");
                    break;
            }
        }
    }

    // This method is responsible for writing to a text file
    // It gets a file name and contents from the user and creates a text file based on the input provided from the user
    public void WriteToFile()
    {
        _view.ShowMessage("Enter file text:");
        string fileText = _view.UserInput();
     
        _view.ShowMessage("Enter file name:");
        string fileName = _view.UserInput();
        
        File.WriteAllText(fileName, fileText);
    }
    // This method is responsible for reading a file and displaying its content to the user.
    public void ReadFile()
    {
        _view.ShowMessage("Enter the name of the text file to read from:");
        string fileName = _view.UserInput();
        string extension = Path.GetExtension(fileName);
        
        if (extension == ".txt")
        {
            _view.ShowMessage("File content:");
            string fileText = File.ReadAllText(fileName);
            _view.ShowMessage(fileText);
        }
        else
        {
            _view.ShowMessage("Invalid file type");
        }
    }
    
}