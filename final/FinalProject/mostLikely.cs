public class MostLikelyTo : Game {
    private List<string> prompts = new List<string>();
    // would i do a filehandler just inside each one or be able to call it in here?
    private List<string> userPrompts = new List<string>();
    private List<string> usedPrompts = new List<string>();
    private int howManyPrompts;

    public void fileHandler(){
        string[] lines = System.IO.File.ReadAllLines("mostLikely.txt");
        // how would i grab random lines and only add those ones?
        foreach (string line in lines)
        {
            prompts.Add(line);
        }
    }

    // enter player names, and ask if they want our preloaded most likely to prompts, or if they want their own
    // the winner is whoever is voted the most overall 
    //bonus challenge if i have time: Save the ones they were voted for and display the ones theyve won
    
    public override void DetermineWinner(List<Player> players){
        Console.WriteLine("Please select the number of the player with the most votes: ");
        DisplayUsers(players);
        int first = int.Parse(Console.ReadLine());

        Console.WriteLine("Please select the player that received the second most points.");
        DisplayUsers(players);
        int second = int.Parse(Console.ReadLine());
        // i need to catch errors if they dont enter a number

        players[first - 1].AddPoints(30);
        players[second - 1].AddPoints(10);
    }
    public override void Begin(List<Player> players)
    {
        while (true)
        {
            Console.WriteLine("Would you like to:\n1. Use our prompts\n2. Enter your own\n3. Return to other games");
            string decision = Console.ReadLine();
            if (decision == "1"){
                mostBegin(prompts, players);
                break;
            }
            else if (decision == "2"){
                // add to our list 
                
                Console.WriteLine("What prompt would you like to add?" );
                string userprompt = Console.ReadLine() ?? string.Empty;
                userPrompts.Add(userprompt);
                
                while(true){
                    Console.WriteLine("Would you like to add another? Yes/No");
                    userprompt = Console.ReadLine() ?? string.Empty;
                    if(userprompt == "no"){
                        mostBegin(userPrompts,players);
                        break;
                    }

                    else if(userprompt == "No"){
                        mostBegin(userPrompts,players);
                        break;
                    }

                    else{
                        Console.WriteLine("Enter next prompt:");
                        userprompt = Console.ReadLine() ?? string.Empty;
                        userPrompts.Add(userprompt);
                    }
                }   
                break;
            }
            else if (decision == "3"){
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
        fileHandler();
        int i = 0;
        Console.WriteLine("How many prompts would you like to go through before game ends?");
        howManyPrompts = int.Parse(Console.ReadLine());

        while(howManyPrompts>prompts.Count()){
            Console.WriteLine($"There are only {prompts.Count()} prompts in desired bank of prompts. Please select a number less than or equal to this amount.");
            howManyPrompts = int.Parse(Console.ReadLine());
        }

        Random random = new Random();

        while(i<howManyPrompts){
            i += 1;
            Console.WriteLine(prompts[random.Next(prompts.Count())]);
            usedPrompts.Add(prompts[random.Next(prompts.Count())]);
            prompts.RemoveAt(random.Next(prompts.Count()));
            DetermineWinner(players);
        }
    }

   
}
