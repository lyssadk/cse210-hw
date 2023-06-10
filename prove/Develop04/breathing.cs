public class Breathing:Activity{

    public Breathing():base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "End Message"){

    }

    public void BreathMessage(int seconds){
        DateTime futureTime = Time(seconds);

        // while loop that takes the seconds the person put in and divides it by 6 seconds to 
        // the lower number and then runs the program that many times of the breathing countdown
        while (DateTime.Now < futureTime){
            
            // breathing program:
            Console.Write("Breathe in for:");
            Console.WriteLine("6");
            Thread.Sleep(6000);

            Console.Write("Breathe out for:");
            Console.WriteLine("6");
            Thread.Sleep(6000);
            //after running 1 time -> -1 from the number of times
        }
    }

    public override void Display()
    {
        Console.Clear();
        base.Display();
        Thread.Sleep(2000);
    }
}