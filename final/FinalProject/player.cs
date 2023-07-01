public class Player{
    protected string _name;
    protected int _score;

    public Player(string name){
        _name = name;
        _score = 0;
    }

    public int AddPoints(int points){
        _score += points;
        return _score;
    }

    public string GetName(){
        return _name;
    }

    public int GetScore(){
        return _score;
    }
}