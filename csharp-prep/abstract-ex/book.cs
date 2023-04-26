public class Book{
    private string _author; //private variable is the underscore author (its hidden from other programmers)
    private string _name;
    private int _timesRead = 0;
    private bool _available = false;

    public Book(string name, string author) // doesnt have a underscore)
    { 
        _name = name;
        _author = author;
    }

    public void Display()
    {
        Console.WriteLine($"{_name} by {_author}");
        if(!_available){
            Console.WriteLine("[Checked out]");
        }
    }

    public bool isAvailable(){
        return _available;
    }
}