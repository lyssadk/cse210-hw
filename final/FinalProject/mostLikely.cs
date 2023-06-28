public class MostLikelyTo : Game {
    private List<string> prompts = new List<string>();
    private List<string> userPrompts = new List<string>();

    // enter player names, and ask if they want our preloaded most likely to prompts, or if they want their own
    // the winner is whoever is voted the most overall 
    // keeps track of which ones everyone gets and displays them at the end if the user wants to
    
    public override Player DetermineWinner(){
        return _winner;
    }
    public override void Begin()
    {
        while (true)
        {
            Console.WriteLine("Would you like to:\n1. Use our prompts\n 2. Enter your own \n3. Add yours to ours\n4. Return to other games");
            string decision = Console.ReadLine();
            if (decision == "1"){
                mostBegin(prompts);
                break;
                // reads from a file that has all the prompts -> puts it in a list
            }
            else if (decision == "2"){
                // creates a list or new file with theirs
                mostBegin(userPrompts);
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
                break;
            }
            else{
                Console.WriteLine("This wasn't an option. Please enter a number");
            }

        }
    }

    public void mostBegin(List<string> prompts){
        foreach (string prompt in prompts)
        {
            Console.WriteLine(prompt);
        };
        Console.WriteLine("Hi");
    }
}
