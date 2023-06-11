public class Reflection:Activity{

    private List<string> _initialPrompts = new List<string>(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
       " Think of a time when you did something truly selfless."
    };

    private List<string> _followPrompts = new List<string>(){
       " Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    Prompt prompt = new Prompt();
    public Reflection(): base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life"){

    }
    public void refStart(int seconds){
        Console.WriteLine("Take a few seconds to think about the following:");
        Console.WriteLine("");
        prompt.GetRandomPrompt(_initialPrompts);
        Console.WriteLine("");

        DateTime future = Time(seconds);
        
        int i = 2;
        /// fix this up brotha 
        while(DateTime.Now < future && i !=0){
            i -=1;
            Thread.Sleep(7000);
            prompt.GetRandomPrompt(_followPrompts);
            Console.WriteLine("");

            if (i == 0){
                Thread.Sleep(7000);
                prompt.GetRandomPrompt(_initialPrompts);
                i += 2; 
            }
        }
        
        Console.WriteLine(Ending(seconds, _name));

    }

    
    public override void Display(){
        base.Display();

    }

}