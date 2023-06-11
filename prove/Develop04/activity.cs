public class Activity{
    protected string _name;
    protected string _description;

    protected int _seconds;

    public Activity(string name, string description){
       _name = name;
       _description = description;
    }

    public virtual void Display(){
        Console.WriteLine($"This is the {_name} Activity.\n{_description}.");
    }

    public int SetSeconds(){
        Console.WriteLine("How many seconds would you like this program to run for?");
        _seconds = int.Parse(Console.ReadLine());
        Console.Write("Get Ready!");
        Countdown(4);

        return _seconds;

    }


    public void Countdown(int count){
    
        do
        {   
            count -= 1;
            Console.Write($"{count}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            

        } while (count>0);         
    }
    public void Spin(int seconds){

        // # help

        DateTime futureTime = Time(seconds);
        Thread.Sleep(3000);

        while (DateTime.Now < futureTime)
        {
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-");
            Console.Write("\b \b");
        }
    }
    public DateTime Time(int seconds){
        DateTime startTime = DateTime.Now;
        return startTime.AddSeconds(seconds);
    }

    public string Ending(int seconds, string activity){
        _seconds = seconds;
        _name = activity;
        return $"You have completed another {_seconds} seconds of the {_name} Activity! Well done";
    }
}