public class Menu{
    private int userChoice;
    private TruthOrDare truthOrDare = new TruthOrDare();
    private MostLikelyTo mostLikelyTo = new MostLikelyTo();
    
    public void display(){
        Console.WriteLine("--------------------------");
        Console.WriteLine("     LETS PARTY HARDY       ");
        Console.WriteLine("--------------------------");
        Console.WriteLine("");
        Console.WriteLine("Select a party game you would like to play:\n1. Most Likely To\n2. Truth or Dare\n 3. Two truths and a lie 4.Quit");
        userChoice = int.Parse(Console.ReadLine());
        while (true){
            if(userChoice == 1){
                mostLikelyTo.Begin();
            }
            else if(userChoice == 2){

            }
            else if(userChoice == 3){

            }
            else if(userChoice == 4){
                break;
            }
           
        }
    }
}