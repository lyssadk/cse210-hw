using System;

class Program
{
    static void Main(string[] args)
    {
        // testing stuff
        List<Person> users = new List<Person>();
        Person alyssa = new Person("alyssa", "securepassw0rd");
        users.Add(alyssa);
        string personname = alyssa.GetName();
        string personpass = alyssa.GetPass();

        Console.WriteLine("Please Enter Your Name:");
        string username = Console.ReadLine();
        Console.WriteLine("Enter password:");
        string password = Console.ReadLine();


        if (password == personpass && username == personname ){
            alyssa.Display();
        }

        else {
            Console.WriteLine("Error: Username or password did not match.");
        }

        // Checklist goal = new Checklist();
        // goal.setPoints();
        
    }
}


