public abstract class Game{
    protected string _GameTitle;

    //truth or dare
    //mostLikely to
    //straigh face
    //2 truths and a lie

    protected List<Player> players;
    protected Player _winner;

    public abstract Player DetermineWinner();

}