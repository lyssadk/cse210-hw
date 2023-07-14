public class Player{
    private string _name;
    private int _score;

    private int _gameScore;

    public Player(string name){
        _name = name;
        _score = 0;
        _gameScore = 0;
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

    public int GetGameScore(){
        return _gameScore;
    }
    public int SetGameScore(int points){
        _gameScore = points;
        return _gameScore;
    }
    public void AddToGameScore(int points){
        _gameScore += points;
    }
}