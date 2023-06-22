public class Person{
    private string name;
    private string password;

    private int _score;
    // this is where their overall score would be?????

    private string _levelName;
    List<string> trees = new List<string>();

    public void Levels(int score){
        if(score <= 5000){
            _levelName = "seed";
        }
        if(score <= 15000){
            _levelName = "sprout";
        }
         if(score <= 30000){
            _levelName = "seedling";
        }
        if(score <= 50000){
            _levelName = "sapling";
        }
        if(score <= 70000){
            _levelName = "tree";
        }
        if(score > 70000){
            _score = 0;
            Console.WriteLine("You Did it! You made a tree. Your points will reset now");
            trees.Add("tree");
        }
        
    }

// dispkay method that would show level name, and how many trees they have.
}