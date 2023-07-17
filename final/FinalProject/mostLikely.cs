public class MostLikelyTo : Game {
    private List<string> prompts = new List<string>();
    // would i do a filehandler just inside each one or be able to call it in here?
    private List<string> userPrompts = new List<string>();
    private List<string> usedPrompts = new List<string>();

    private int _second;
    private int _first;


    // enter player names, and ask if they want our preloaded most likely to prompts, or if they want their own
    // the winner is whoever is voted the most overall 
    //bonus challenge if i have time: Save the ones they were voted for and display the ones theyve won
    
    public override void DetermineWinner(List<Player> players){
        try
        {
            Console.WriteLine("Please select the number of the player with the most votes: ");
            DisplayUsers(players);
            _first = int.Parse(Console.ReadLine());

            if (_first>players.Count()){
                Console.WriteLine("That number isn't an option. Please select one of the options.");
                _first = int.Parse(Console.ReadLine());
            }
        }

        catch (System.Exception)
        {
            Console.WriteLine("Please enter the number of the associated player who won the most points");
            _first = int.Parse(Console.ReadLine());
        }

        try
        {
            Console.WriteLine("Please select the player that received the second most points.");
            DisplayUsers(players);
            _second = int.Parse(Console.ReadLine());

            if (_second>players.Count()){
                Console.WriteLine("That number isn't an option. Please select one of the options.");
                _second = int.Parse(Console.ReadLine());
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine("Please enter the number of the associated player who won 2nd most points");
            _second = int.Parse(Console.ReadLine());
        }
        // i need to catch errors if they dont enter a number
        
        players[_first - 1].AddPoints(30);
        players[_second - 1].AddPoints(10);
            
        
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
                try
                {  
                    Console.WriteLine("What prompt would you like to add?" );
                    string userprompt = Console.ReadLine();
                    userPrompts.Add(userprompt);
                    while(true){
                        Console.WriteLine("Would you like to add another? Yes/No");
                        userprompt = Console.ReadLine();
                        if(userprompt.ToLower() == "no"){
                            mostBegin(userPrompts,players);
                            break;
                        }

                        else{
                            Console.WriteLine("Enter next prompt:");
                            userprompt = Console.ReadLine();
                            userPrompts.Add(userprompt);
                        }
                    }   
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("There has been an error, apologies.");
                }
                
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
        filer.filer(prompts, "mostLikely.txt");
        int i = 0;
        Console.WriteLine("How many prompts would you like to go through before game ends?");
        intChoice = int.Parse(Console.ReadLine());

        while(intChoice>prompts.Count()){
            Console.WriteLine($"There are only {prompts.Count()} prompts in desired bank of prompts. Please select a number less than or equal to this amount.");
            intChoice = int.Parse(Console.ReadLine());
        }

        Random random = new Random();

        while(i<intChoice){
            i += 1;
            Console.WriteLine(prompts[random.Next(prompts.Count())]);
            usedPrompts.Add(prompts[random.Next(prompts.Count())]);
            prompts.RemoveAt(random.Next(prompts.Count()));
            DetermineWinner(players);
            Console.Clear();
        }
    }

   
}
