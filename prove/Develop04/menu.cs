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
            Console.WriteLine("Welcome to the Minfulness program. Please type the number\n of which activity you would like to do.\n 1. Breathing Activity \n 2. Listing Activity \n 3. Reflection Activity \n 4. Quit");
            _userChoice = Console.ReadLine();
            int secondsl = list.SetSeconds();
            // other option could be activity.setseconds instead?
            
            if (_userChoice == "1"){
                breathing.Display();
                breathing.BreathMessage(secondsl);
                Console.Clear();
                // ideally this would have it wait for the allotted time the user put in before running menu again. but ??? who knows.
                Thread.Sleep((secondsl*10)+100);
            }
            if (_userChoice == "2"){
                list.Display();
                list.begin(secondsl);
                // Thread.Sleep((secondsl*1000)+100);
            }
            if (_userChoice == "3"){
                reflection.Display();
                reflection.refStart(secondsl);
                Thread.Sleep((secondsl*1000)+100);
            }
            if (_userChoice == "4"){
                Console.WriteLine("Have a nice day:)");
                _runMenu = false;
            }
        }   
    }
}