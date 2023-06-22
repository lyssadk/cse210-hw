public class Eternal : Goal{

    // i want this to keep track of 
  public override void setPoints(){
     while ( _difficulty == 0)
        {
            Console.WriteLine("How hard is this goal for you on a scale of 1-5? (enter a whole number)");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber > 5 ){
                Console.WriteLine("Consider ways you can make this less challenging for yourself. Consider breaking it down into smaller goals. You got this.");
                _points = 50;
                _difficulty = 6;
            }
            
            else {
                _points = userNumber * 10; // i swear if this works
                _difficulty = userNumber;
            }
            
            Console.WriteLine($"It will be worth {_points} points when you complete it");
        }
  }
}