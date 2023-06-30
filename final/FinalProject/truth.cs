public class TruthOrDare : Game {
    private List<string> truths = new List<string>();
    private List<string> dares = new List<string>();
    public override Player DetermineWinner(){
        
        return _winner;
    }
    public override void Begin(List<Player> players)
    {
        // users would get options of beginning, and cyclying through
    }
}