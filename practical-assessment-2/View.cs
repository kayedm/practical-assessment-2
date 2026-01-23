namespace practical_assessment_2;

public class View {
    
    public int OptionsMenu()
    {
        Console.WriteLine("Pick an option:");
        Console.WriteLine("1) Write file");
        Console.WriteLine("2) Read file");
        Console.WriteLine("3) Exit");
        
        return int.Parse(Console.ReadLine());
        
    }
    
    public void ShowMessage(String message)
    {
        Console.WriteLine(message);
    } 
    
    public string UserInput()
    {
        string input = Console.ReadLine();
        return input;
    }
    
    public void DisplayFileContent(String fileContent)
    {
        Console.Write("Enter text: ");
        Console.Write(fileContent);
    }
    
    
}