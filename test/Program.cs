using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Please Enter Your Name:");
        string username = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Enter password:");
        string password = Console.ReadLine() ?? string.Empty;


        string filename = $"{username}.txt";
        fileHandler fileHandle = new fileHandler(filename);
        List<Goal> goals = fileHandle.GetGoals();
    
        
        Menu menu = new Menu();
        menu.Display(goals, filename);
       
        
    }
}