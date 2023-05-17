
public class Prompt{
     List<string> _promptlist = new List<string>();
     List<string> _usedlist = new List<string>();
    public string Random(){
        var random = new Random();
        int randomnum = random.Next(_promptlist.Count);
        return _promptlist[randomnum];
    }
    
    public Prompt(){
        _promptlist.Add("What is something that made you happy today? ");
        _promptlist.Add("What is something you could've done better on? ");
        _promptlist.Add("What is one thing you are grateful for? ");
        _promptlist.Add("What is something that was hard? ");
        _promptlist.Add("What is one thing you learned today? ");
        _promptlist.Add("How can you make tomorrow even better?");
        _promptlist.Add("What is something interesting you saw today?");
        _promptlist.Add("if you had to describe your day in 3 words, how would you describe it?");
    }

    public void removePrompt(){
       // _usedlist.Add(_promptlist[index]);
    }
        
    }