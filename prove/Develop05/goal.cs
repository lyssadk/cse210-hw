public abstract class Goal{
    protected int _points;
    protected int _difficulty = 0;
    protected string _description;
    protected string _goalType;
    protected string _title;
    protected bool _isCompleted = false;

    public Goal(){
        Console.WriteLine("What is the Goal Type (emotional, spiritual, physical, social)? ");
        _goalType = Console.ReadLine();

        Console.WriteLine("What is the description? ");
        _description = Console.ReadLine();

        Console.WriteLine("What would you like to title your goal as? ");
        _title = Console.ReadLine();
        
    }

    public Goal( string title, string goaltype, string description, int points, int difficulty){
        _title = title;
        _description = description;
        _goalType = goaltype;
        _points = points;
        _difficulty = difficulty;
    }

    public abstract void setPoints();

    public void Complete(){
        // this would set a goal they check off as completed? maybe or do i  do that somewhere else???
    }

    public int GetPoint(){
        return _points;
    }
   
}