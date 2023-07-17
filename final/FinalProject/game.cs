public abstract class Game{
    protected fileHandler filer = new fileHandler();
    
    protected int intChoice;
    protected Player _winner = new Player("");
    
    public abstract void DetermineWinner(List<Player> players);
    public abstract void Begin(List<Player> players);
    public void DisplayUsers(List<Player> players){
        int i = 1;
        foreach (Player player in players){
            Console.WriteLine($"{i}. {player.GetName()}");
            i += 1;
        }
    }
}