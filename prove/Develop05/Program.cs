using System;

class Program
{
    static void Main(string[] args)
    {

        fileHandler filer = new fileHandler();
        List<Goal> goals = filer.Load();

        Menu menu = new Menu();
        menu.Display(goals, filer.GetFileName(), filer.getUser(), filer);

        
    }
}


//wireframe