public class Person{
    private string _name;
    private string _password;

    private int _score = 0;
    // this is where their overall score would be?????

    private string _levelName;
    List<string> trees = new List<string>();
    List<Goal> goals = new List<Goal>(); // keeps track of their goals yeah?

    public Person(string name, string password){
        _name = name;
        _password = password;
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
            trees.Add("tree");
        }

        if (goals.Count == 30){
            // how could i make this so every 30 goals they complete earns them a tree?
            // for each time 30 goes into the goals count is 1 tree added?
        }
        
    }

    public string GetName(){
        return _name;
    }

    public string GetPass(){
        return _password;
    }

    // where shnoudl i put this class?
    public void calculateScore(List<Goal> list){
        foreach (Goal goal in list)
        {
            _score =+ goal.GetPoint();
        }
    }

// dispkay method that would show level name, and how many trees they have.
    public void Display(){
        Levels(_score);
        Console.WriteLine($"Name: {_name} || Current Score: {_score} || Tree Status: {_levelName} || Tree Count: {trees.Count}");
    }
}