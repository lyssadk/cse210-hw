public abstract class Goal{
    protected int _points;
    protected int _difficulty = 0;
    protected string _description;
    protected string _goalType;
    protected string _title;
    protected bool _complete = false;

    public Goal(string goalType){
        _goalType = goalType;
        Console.WriteLine("What is the description? ");
        _description = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("What would you like to title your goal as? ");
        _title = Console.ReadLine() ?? string.Empty;
        
    }

    public Goal( string title, string description, int points, int difficulty, bool complete){
        _title = title;
        _description = description;
        _complete = complete;
        _points = points;
        _difficulty = difficulty;
    }
    public Goal( string title, string description, int points, int difficulty ){
        _title = title;
        _description = description;
        _points = points;
        _difficulty = difficulty;
    }

    public abstract void setPoints();
    public abstract string GetStringRepGoal();

    public bool GetComplete(){
        return _complete;
    }

    public virtual bool SetComplete(){
        _complete = true;
        return _complete;
    }

    public bool SetFalse(){
        _complete = false;
        return _complete;
    }

    public int GetPoint(){
        return _points;
    }

    public string GetGoalType(){
        return _goalType;
    }
    public virtual void Display(){
        Console.WriteLine($"{_goalType}: {_title} || Description: {_description} || Points: {_points} || Difficulty: {_difficulty} || Completed: {_complete}");
    }
   
}