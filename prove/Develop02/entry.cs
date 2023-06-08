public class Entry{

    public string entry = "";
    public string date;
    public string prompt;
    
    public Entry(){
     DateTime theCurrentTime = DateTime.Now;
     date = theCurrentTime.ToShortDateString();

      Prompt lprompt = new Prompt();
      //prompt = lprompt.Random();

    }

}