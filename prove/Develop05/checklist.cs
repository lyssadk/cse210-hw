public class Checklist : Goal {
    private int _bonusPoint;
    private int _checklistAmount;
    public override void setPoints()
    {
        while ( _difficulty == 0)
        {
            Console.WriteLine("How hard is this goal for you on a scale of 1-5? (enter a whole number)");
            int userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("How many times should it be completed for bonus points?");
            _checklistAmount = int.Parse(Console.ReadLine());
            if (userNumber > 5 ){
                Console.WriteLine("You mentioned it was above a 5 on difficulty./n Consider ways you can make this less challenging for yourself. Consider breaking it down into smaller goals./n You got this.");
                _points = 100;
                _difficulty = 6;
                _bonusPoint = _checklistAmount * 80;
            }
            
            else {
                _points = userNumber * 20; // i swear if this works
                _difficulty = userNumber;
                _bonusPoint = _checklistAmount*(userNumber * 20);
            }
            
            Console.WriteLine($"It will be worth {_points} points each time you complete it");
            Console.WriteLine($"You will receive {_bonusPoint} bonus points when you complete it {_checklistAmount} times.");

        }
    }

}