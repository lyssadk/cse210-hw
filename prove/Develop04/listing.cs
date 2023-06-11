public class Listing:Activity{

    private List<string> _prompts = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // tutoring question: maybe because im creating a new instance of list everytime?
    private List<int> _intlist = new List<int>(){
        0,1,2,3,4
    };

    Prompt prompt = new Prompt();

    private List<string> _entries = new List<string>();

    public Listing():base("Listing", "This activity will help you reflect on the good things in your life\n by having you list as many things as you can in a certain area."){

    }

    public override void Display(){
        base.Display();
    }

    public void begin(int seconds){
        
        DateTime futureTime = Time(seconds);
        Thread.Sleep(1000);

        // grabs a random prompt
        prompt.GetRandomPrompt(_prompts);

        while (DateTime.Now < futureTime){
        // code here that loops, running the readline until the timer is up that they set!
            string entry = Console.ReadLine();
            _entries.Add(entry);
        }
        // counts how many they were able to list
        entriesCount(seconds);
        
        //end message 
        Console.WriteLine(Ending(seconds, _name));

        // clears the list afterwards so it starts fresh next time.
        _entries.Clear();
    }
    public void entriesCount(int seconds){
        // count how many entries they were able to list in their timeframe.
        int entryC = _entries.Count();
        if (seconds >= 0 && seconds <= 30){
            if (entryC > 7){
                Console.WriteLine($"\nYou were able to list {entryC} items in {seconds} seconds. Pop off thats crazy.");
            }
            else{
                Console.WriteLine($"\nYou were able to list {entryC} items in {seconds} seconds. You really pondered and took your time.");
            }
        }
        else if (seconds >= 60 && seconds <=120){
              if (entryC > 25){
                Console.WriteLine($"\nYou were able to list {entryC} items in {seconds} seconds. Pop off thats crazy.");
            }
            else{
                Console.WriteLine($"\nYou were able to list {entryC} items in {seconds} seconds. You really pondered and took your time.");
            }
        }
        else{
            Console.WriteLine($"You were able to list {entryC} items in {seconds} seconds.");
        }
    }


}