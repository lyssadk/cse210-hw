public abstract class Game{
    protected string _GameTitle;
    protected fileHandler filer = new fileHandler();
    //truth or dare
    //mostLikely to
    //straigh face
    //2 truths and a lie
    protected int intChoice;
    protected Player _winner = new Player("");
    protected List<Player> _winners = new List<Player>();
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