public class Person{
    private string _name;
    private string _password;
    private int _score;
    private string _levelName;
    private int _trees;
   
    public Person(string name, string password){
        _name = name;
        _password = password;
        _levelName = "seed";
        _trees = 0;
        _score = 0;

    }
     public Person(string name, string password, int score, string levelName, int trees){
        _password = password;
        _score = score;
        _levelName = levelName;
        _trees = trees;
        _name = name;
    }
    public void Levels(int score){
        if(score <= 5000){
            _levelName = "seed";
        }
        if( 5001 <= score && score <= 15000){
            _levelName = "sprout";
        }
         if(15001 <= score && score <=30000){
            _levelName = "seedling";
        }
        if(30001<= score && score <= 50000){
            _levelName = "sapling";
        }
        if(50001<= score && score <= 70000){
            _levelName = "tree";
        }
        if(score > 70000){
            _score = 0;
            Console.WriteLine("You Did it! You made a tree. Your points will reset now");
            _trees =+ 1;
        }
    }
   
    public int calculateScore(Goal goal){
     
        _score += goal.GetPoint();
        return _score;
    }

// dispkay method that would show level name, and how many trees they have.
    public void Display(List<Goal> goals){
        // _score = calculateScore(goals);
        Levels(_score);
        Console.WriteLine($"Name: {_name} || Current Score: {_score} || Tree Status: {_levelName} || Tree Count: {_trees}");
    }

    public string GetStringRep(){
        return $"{_password},{_levelName},{_score},{_trees}";
    }
}