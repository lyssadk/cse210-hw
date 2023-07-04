public class TruthOrDare : Game {
    private List<string> _truths = new List<string>();
    private List<string> _dares = new List<string>();
    private List<string> _usedPrompts = new List<string>();

    private string _decision;
    private string _skipOr;
    public override void DetermineWinner(List<Player> players){
        foreach(Player player in players){
            player.AddPoints(player.GetGameScore());
            foreach(Player player2 in players){
                if(player == player2){
                    continue;
                }
                else if(player.GetGameScore() > player2.GetGameScore()){
                    // i would need another variable i think in the player class mayber to return? cause rn its just their overall score and not specifcally this game...
                    // if player has a greater score it will be set as the winner. ??? 
                    _winner = player;
                }
                else if(player.GetGameScore() < player2.GetGameScore()){
                    _winner = player2;
                }
                // what would i do if their is a tie?
            }
            /// look at how many points the player got playing this particular game and award bonus points if they win overall.../?????
        }

        Console.WriteLine($"{_winner.GetName()} won this game, they have been awarded a bonus 100 points");
        _winner.AddPoints(100);
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

        fileHandlerTruth("truth.txt", _truths);
        fileHandlerTruth("dare.txt", _dares);

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
    public void fileHandlerTruth(string filename, List<string> list){
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach (string line in lines)
        {
            list.Add(line);
        }

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