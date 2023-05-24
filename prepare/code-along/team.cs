public class Team{
    private List<Player> _players = new List<Player>();
    private string _name = "";

    private int _wins = 0;
    private int _losses = 0;
    public Team(string name, int wins, int losses){
        _name = name;
        _losses = losses;
        _wins = wins;

    }

    public void addWin(){
        _wins += 1;
    }
     public void addLoss(){
        _wins += 1;
    }

    public void AddPlayer(Player p){
        _players.Add(p);
    }

    public void DisplayRoster(){
        Console.WriteLine($"{_name}, {_wins}/{_losses} ");
        foreach (Player player in _players)
        {
            Console.WriteLine(player.Display());
        }
    }
}