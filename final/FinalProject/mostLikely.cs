public class MostLikelyTo : Game {
    private List<string> prompts = new List<string>();
    // would i do a filehandler just inside each one or be able to call it in here?
    private List<string> userPrompts = new List<string>();

    private int howManyPrompts;

    // enter player names, and ask if they want our preloaded most likely to prompts, or if they want their own
    // the winner is whoever is voted the most overall 
    // keeps track of which ones everyone gets and displays them at the end if the user wants to
    
    public override Player DetermineWinner(){
        return _winner;
    }
    public override void Begin(List<Player> players)
    {
        while (true)
        {
            Console.WriteLine("Would you like to:\n1. Use our prompts\n 2. Enter your own \n3. Add yours to ours\n4. Return to other games");
            string decision = Console.ReadLine();
            if (decision == "1"){
                mostBegin(prompts, players);
                break;
                // reads from a file that has all the prompts -> puts it in a list
            }
            else if (decision == "2"){
                // creates a list or new file with theirs
                mostBegin(userPrompts, players);
                break;
            }
            else if (decision == "3"){
                // add to our list 
                
                Console.WriteLine("What prompt would you like to add?" );
                string userprompt = Console.ReadLine() ?? string.Empty;
                prompts.Add(userprompt);
                
                while(true){
                    Console.WriteLine("Would you like to add another? Yes/No");
                    userprompt = Console.ReadLine() ?? string.Empty;
                    if(userprompt == "no"){
                        break;
                    }

                    else if(userprompt == "No"){
                        break;
                    }

                    else{
                        Console.WriteLine("Enter next prompt:");
                        userprompt = Console.ReadLine() ?? string.Empty;
                        prompts.Add(userprompt);
                    }
                }   
                break;
            }
            else if (decision == "4"){
                // do nothing so it goes back to the main program.
                Console.WriteLine("Heading back to main menu");
                Thread.Sleep(2000);
                Console.Clear();
                break;
            }
            else{
                Console.WriteLine("This wasn't an option. Please enter a number");
            }

        }
    }

    public void mostBegin(List<string> prompts, List<Player> players){

        Console.WriteLine("How many prompts would you like to go through before game ends?");
        howManyPrompts = int.Parse(Console.ReadLine());
        // this would grab however many random prompts from the file text and add them to the prompts list so we could do some things with it.
        // foreach (string line in lines)
        // {
        //     prompts.Add(line);
        // };
        foreach (string prompt in prompts){
            Console.WriteLine(prompt);
            Console.Write("Please select with the most votes: ");
            foreach (Player player in players){
                int i = 1;
                Console.WriteLine($"{i}. {player.GetName()}");
                i += 1;
            }
            string first = Console.ReadLine();
            Console.WriteLine("Please select the player that received the second most points.");

            foreach (Player player in players)
            {
                int i = 1;
                Console.WriteLine($"{i}. {player.GetName()}");
                i += 1;

            }
                string second = Console.ReadLine();
            }
    
    }
}
