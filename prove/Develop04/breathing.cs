public class Breathing:Activity{

    public Breathing():base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "End Message"){

    }

    public void BreathMessage(){
       
    }

    public override void Display()
    {
        Console.Clear();
        base.Display();
        Thread.Sleep(2000);
    }
}