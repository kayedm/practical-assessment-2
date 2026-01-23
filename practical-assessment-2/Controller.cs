namespace practical_assessment_2;

public class Controller {

    private View view;

    public Controller(View view)
    {
        this.view = view;
    }

    public void Run()
    {
        bool running =  true;
        
        while (running)
        {
            int choice = view.OptionsMenu();
            
            switch (choice)
            {
                case 1: 
                    WriteToFile();
                    break;
                case 2:
                    ReadFile();
                    break;
                case 3:
                    running = false;
                    break;
                default:
                    view.ShowMessage("Invalid option");
                    break;
            }
        }
    }

    public void WriteToFile()
    {
        view.ShowMessage("Enter file name:");
        string fileName = view.UserInput();
        view.ShowMessage("Enter file text:");
        string fileText = view.UserInput();
        File.WriteAllText(fileName, fileText);
    }

    public void ReadFile()
    {
        view.ShowMessage("Enter the name of the text file to read from:");
        string fileName = view.UserInput();
        string fileText = File.ReadAllText(fileName);
        view.ShowMessage(fileText);
    }
    
}