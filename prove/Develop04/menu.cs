public class Menu{
    private string _userChoice;
    private bool _runMenu = true;

    // my activity line was added but not sure if i need it rlly.
    // Activity activity = new Activity();

    Breathing breathing = new Breathing();
    Listing list = new Listing();
    Reflection reflection = new Reflection();
    public void DisplayMenu(){
        while (_runMenu == true){
            
            Console.WriteLine("\nPlease type the number of which activity you would like to do.\n\n 1. Breathing Activity \n 2. Listing Activity \n 3. Reflection Activity \n 4. Quit");
            _userChoice = Console.ReadLine();
            
            // other option could be activity.setseconds instead?
            
            if (_userChoice == "1"){
                Console.Clear();
                breathing.Display();
                int secondsl = breathing.SetSeconds();
                breathing.BreathMessage(secondsl);
                // ideally this would have it wait for the allotted time the user put in before running menu again. but ??? who knows.
            }
            if (_userChoice == "2"){
                Console.Clear();
                list.Display();
                int secondsl = list.SetSeconds();
                list.begin(secondsl);
                Thread.Sleep(3500);
            }
            if (_userChoice == "3"){
                Console.Clear();
                reflection.Display();
                int secondsl = reflection.SetSeconds();
                reflection.refStart(secondsl);
            }
            if (_userChoice == "4"){
                Console.Clear();
                Console.WriteLine("Have a nice day:)");
                _runMenu = false;
            }
        }   
    }
}