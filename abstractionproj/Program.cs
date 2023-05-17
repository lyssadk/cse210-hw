// See https://aka.ms/new-console-template for more informat
class Program{
    static void Main(string[] args){
        Menu menu = new Menu();
        //Journal journal = new Journal();

        while (true) {
            Console.WriteLine("Welcome to the Journal Program!\nPlease select one of the following options:\n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
            string? input = Console.ReadLine();

            if (input == "1")
            {
             menu.newEntry();   
            }
            else if(input == "2")
            {
                //journal.displayEntry();
            }
            else if (input == "3"){

            }
            else if (input == "4") {

            }
            else if (input == "5") {
                break;
            }
        }
        
    }
}

