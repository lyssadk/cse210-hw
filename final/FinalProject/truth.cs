public class TruthOrDare : Game {
    private List<string> _truths = new List<string>();
    private List<string> _dares = new List<string>();
    private List<string> _usedPrompts = new List<string>();

    int BONUS = 50;
    private string _decision;
    private string _skipOr;
    public override void DetermineWinner(List<Player> players){
        
        foreach(Player player in players){
            player.AddPoints(player.GetGameScore());
        }
        foreach (Player player in players){
            if (player.GetGameScore() >= _winner.GetGameScore()){
                _winner = player;
            }
        }

        foreach (Player player in players)
        {
            if(_winner.GetGameScore() == player.GetGameScore()){
                player.AddPoints(BONUS);
                Console.WriteLine($"{player.GetName()} got BONUS points yerr");
            }
        }
    
    }
    public override void Begin(List<Player> players)
    {
        while (true)
        {
            Console.WriteLine("Would you like to:\n1. Begin \n2. Return to other games");
            string decision = Console.ReadLine();
            if (decision == "1"){
                truthBegin(players);
                break;
            }
            
            else if (decision == "2"){
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
    public void truthBegin(List<Player> players)
    {
        int i = 0;
        Console.WriteLine("How many prompts would you like to go through before game ends?");
        intChoice = int.Parse(Console.ReadLine());
      
        filer.filer(_truths, "truth.txt");
        filer.filer(_dares, "dare.txt");

        while(i < intChoice){
           
            i += 1;
            
            foreach(Player player in players){
                Console.Clear();
                Console.WriteLine($"{player.GetName()}, truth or dare?");
                _decision = Console.ReadLine();

                
                if(_decision.ToLower() == "truth"){
                    skipOrComplete(player, _truths, 25);
                }

                else if(_decision.ToLower() == "dare"){
                    skipOrComplete(player, _dares, 35);
                }

                else {
                    while (true){
                        
                        Console.WriteLine("Please type in truth or dare.");
                        _decision = Console.ReadLine();
                        if(_decision.ToLower() == "truth"){
                            skipOrComplete(player, _truths, 25);
                            break;
                        }

                        else if(_decision.ToLower() == "dare"){
                            skipOrComplete(player, _dares, 35);
                            break;
                        }
                    }
                }
            }
        }
        Console.Clear();
        DetermineWinner(players);
    }
    public void skipOrComplete(Player player, List<string> list, int points){
        Random random = new Random();
        int randomN = random.Next(list.Count());

        Console.WriteLine(list[randomN]);

        _usedPrompts.Add(list[randomN]);
        list.RemoveAt(randomN);

        Console.WriteLine("Skip or Complete?");
        _skipOr = Console.ReadLine();
        
        if(_skipOr.ToLower() == "skip"){
            Console.WriteLine("Wimp. No points will be added.");
            Thread.Sleep(2000);
        }

        else if(_skipOr.ToLower() == "complete"){
            player.AddToGameScore(points);
            Console.WriteLine($"{points} Points have been awarded.");
            Thread.Sleep(2000);
        }
    }
    
}