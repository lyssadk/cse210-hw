public class Simple : Goal{

    public Simple(string title, string description, int points, int difficulty, bool complete): base(title, description, points, difficulty, complete){
        _goalType = "Simple";

    }

    public Simple(string goalType):base(goalType){

    }
    public override void setPoints(){
         while ( _difficulty == 0)
        {
            Console.WriteLine("How hard is this goal for you on a scale of 1-5? (enter a whole number)");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber > 5 ){
                Console.WriteLine("Consider ways you can make this less challenging for yourself. Consider breaking it down into smaller goals. You got this.");
                _points = 150;
                _difficulty = 6;
            }
            
            else {
                _points = userNumber * 25; // i swear if this works
                _difficulty = userNumber;
            }
            
            Console.WriteLine($"It will be worth {_points} points when you complete it");
        }
    }
    public override bool SetComplete()
    {
        return base.SetComplete();
    }

    public override string GetStringRepGoal(){
        return $"{_goalType}:{_title},{_description},{_points},{_difficulty},{_complete}";
    }
}