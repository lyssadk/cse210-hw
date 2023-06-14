public class Breathing:Activity{

    public Breathing():base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly.\n Clear your mind and focus on your breathing."){

    }

    public void BreathMessage(){
        DateTime futureTime = Time(_seconds);
        

        // while loop that takes the seconds the person put in and divides it by 6 seconds to 
        // the lower number and then runs the program that many times of the breathing countdown
        while (DateTime.Now < futureTime){
            Console.Clear();
            // breathing program:
            Console.Write("Breathe in for: ");
            Countdown(6);
            Console.WriteLine("");
            Console.Write("Breathe out for:");
            Countdown(6);
            Console.Clear();
        }
        Console.WriteLine(Ending(_seconds, _name));
    }

    public override void Display()
    {
        Console.Clear();
        base.Display();
        Thread.Sleep(3000);
    }
}