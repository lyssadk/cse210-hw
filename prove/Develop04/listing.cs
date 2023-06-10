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

    public Listing():base("Listing", "description", "End Message"){

    }

    public override void Display(){
        base.Display();
    }

    public void begin(int seconds){
        // Spin();
        DateTime startT = DateTime.Now;
        DateTime futureT = startT.AddSeconds(seconds);

        Thread.Sleep(1000);
        DateTime currentTime = DateTime.Now;

        // grabs a random prompt
        prompt.GetRandomPrompt(_prompts);

        while (currentTime < futureT){
        // code here that loops, running the readline until the timer is up that they set!, BUT IT NEVER STOPS???????????????????? HELP????????
            string entry = Console.ReadLine();
            _entries.Add(entry);

            //me tryna catch my errors???
            if (entry == "quit"){
                entriesCount(seconds);
                break;
            }


        }

        entriesCount(seconds);
    }
    public void entriesCount(int seconds){
        // count how many entries they were able to list in their timeframe.
        int entryC = _entries.Count();
        if (seconds >= 0 && seconds <= 30){
            if (entryC < 7){
                Console.WriteLine($"You were able to list {entryC} items in {seconds} seconds. Pop off thats crazy.");
            }
            else{
                Console.WriteLine($"You were able to list {entryC} items in {seconds} seconds. You really pondered and took your time.");
            }
        }
        else if (seconds >= 60 && seconds <=120){
              if (entryC < 15){
                Console.WriteLine($"You were able to list {entryC} items in {seconds} seconds. Pop off thats crazy.");
            }
            else{
                Console.WriteLine($"You were able to list {entryC} items in {seconds} seconds. You really pondered and took your time.");
            }
        }
    }


}