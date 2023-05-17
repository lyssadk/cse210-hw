using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        while (true) {
            Console.WriteLine("Welcome to the Journal Program!\nPlease select one of the following options:\n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
            string? input = Console.ReadLine();

            if (input == "1")
            {
             menu.newEntry();   
            }
            else if(input == "2")
            {
                menu.journal.displayEntry();
            }
            else if (input == "3"){
                menu.journal.loadEntry();
            }
            else if (input == "4") {
                menu.journal.saveEntry();

            }
            else if (input == "5") {
                break;
            }
        }
    }
}