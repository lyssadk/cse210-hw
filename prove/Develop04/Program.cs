using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        Console.WriteLine("\n----------------------------------");
        Console.Write("Welcome to the Mindfulness program.");
        Menu menu = new Menu();
        menu.DisplayMenu();
    }
}