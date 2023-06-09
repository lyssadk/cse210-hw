public class TruthOrDare : Game {
    private List<string> _truths = new List<string>();
    private List<string> _dares = new List<string>();
    private List<string> _usedPrompts = new List<string>();

    int BONUS = 50;
    private string _decision;
    private string _skipOr;
    public override void DetermineWinner(List<Player> players){
        // Player bestScore = new Player("");
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
                Console.WriteLine($"{player.GetName()} tied for winner");
            }
        }

        Console.WriteLine($"{_winner.GetName()} won this game, they have been awarded a bonus 100 points");
    
    }

    public override void Begin(List<Player> players)
    {
        int i = 0;
        Console.WriteLine("How many rounds would you like to go through before game ends?");
        try{
            intChoice = int.Parse(Console.ReadLine());
        }
        catch{
            Console.WriteLine("Please enter a number.");
        }

        filer.filer(_truths, "truth.txt");
        filer.filer(_dares, "dare.txt");

        while(i < intChoice){
           
            i += 1;
            
            foreach(Player player in players){
                Console.WriteLine($"{player.GetName()}, truth or dare?");
                _decision = Console.ReadLine();
                if(_decision.ToLower() == "truth"){
                    skipOrComplete(player, _truths, 25);
                }
                else if(_decision.ToLower() == "dare"){
                    skipOrComplete(player, _dares, 35);
                }
                else{
                    Console.WriteLine("Please type in truth or dare.");
                }
            }
        }
        DetermineWinner(players);
    }
    public void skipOrComplete(Player player, List<string> list, int points){
        Random random = new Random();
        int randomN = random.Next(list.Count());
        Console.WriteLine(list[randomN]);
        Console.WriteLine(list.Count());
        _usedPrompts.Add(list[randomN]);
        list.RemoveAt(randomN);

        Console.WriteLine(list.Count());
        Console.WriteLine("Skip or Complete?");
        _skipOr = Console.ReadLine();
            if(_skipOr.ToLower() == "skip"){
                Console.WriteLine("Wimp. No points will be added.");
            }
            else if(_skipOr.ToLower() == "complete"){
                player.SetGameScore(points);
                Console.WriteLine("25 Points have been awarded.");
            }
    }
    
}