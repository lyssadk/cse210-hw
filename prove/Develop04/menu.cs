public class Menu{
    private string _userChoice = "-1";
    private bool _runMenu = true;
    public void DisplayMenu(){
        do
        {
            Console.WriteLine("Welcome to the Minfulness program. Please type the number\n of which activity you would like to do.\n 1. Breathing Activity \n 2. Listing Activity \n 3. Reflection Activity \n 4. Quit");
            _userChoice = Console.ReadLine();
            
            if (_userChoice == "1"){
                Breathing breathing = new Breathing();
            }
            if (_userChoice == "2"){
                Listing list = new Listing();
            }
            if (_userChoice == "3"){
                Reflection reflection = new Reflection();
            }
            if (_userChoice == "4"){
                _runMenu = false;
            }
        } while (_runMenu == true);

    }
}