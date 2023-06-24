public class Person{
    private string _name;

    private string _password;

    private int _score;
    // this is where their overall score would be

    private string _levelName;
    private int _trees;
    //List<Goal> goals = new List<Goal>(); // keeps track of their goals yeah?

// constructor: new users get set to 0 automatically. 
    public Person(string name, string password){
        _name = name;
        _password = password;
        _levelName = "seed";
        _trees = 0;
        _score = 0;

    }
// constructor: builds a person if they have a text file with this info already
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
            _levelName = "seed";
        }

        // if (goals.Count == 30){
        //     // how could i make this so every 30 goals they complete earns them a tree?
        //     // for each time 30 goes into the goals count is 1 tree added?
        // }
        
    }

    public string GetName(){
        return _name;
    }

    public string GetPass(){
        return _password;
    }

    // where shnoudl i put this class?
    public int calculateScore(List<Goal> list){

        if(list.Count != 0){
            foreach (Goal goal in list)
            {
                _score =+ goal.GetPoint();
                return _score;
            }
        }

        else {
            _score = 0;
        }

        return _score;

    }

// dispkay method that would show level name, and how many trees they have.
    public void Display(Person person, List<Goal> list){
        int score = person.calculateScore(list);
        Levels(score);
        Console.WriteLine($"Name: {_name} || Current Score: {score} || Tree Status: {_levelName} || Tree Count: {_trees}");
    }

    public string GetStringRep(string password, string levelName, int score, int trees){
        return $"{password},{levelName},{score},{trees}";
    }
}