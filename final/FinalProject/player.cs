public class Player{
    protected string _name;
    protected int _score;

    public int AddPoints(int points){
        _score += points;
        return _score;
    }
}