public class Activity{
    protected string _name = "test";
    protected string _description = "test";
    protected int _seconds;
    private string _EndMessage;

    public Activity(string name, string description, string EndMessage){
       _name = name;
       _description = description;
       _EndMessage = EndMessage;
    }
      public Activity(){
       _name = "";
       _description = "";
       _EndMessage = "";
    }

    public virtual void Display(){
        Console.WriteLine($"This is the {_name} Activity. {_description}.");
        SetSeconds();
        Countdown();

    }

    public int SetSeconds(){
        Console.WriteLine("How many seconds would you like this program to run for?");
        return Console.Read();

    }

    public void Pause(){

    }

    public void Countdown(){
        Console.WriteLine($"Beginning {_name} Activity in: ");
        int i = 4;
    
        do
        {   
            i -= 1;
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");

        } while (i>0);         
    }
    public void Spin(){

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_seconds);

        Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("\\");
        }
    }

}