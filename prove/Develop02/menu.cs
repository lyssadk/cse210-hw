public class Menu{

    public Menu(){

    }

    public Journal journal = new Journal();

    public void newEntry(){
        Entry entry = new Entry();
        Console.WriteLine(entry.prompt);
        Console.WriteLine("Please write your entry:");
        entry.entry = Console.ReadLine() ?? String.Empty;

        journal.entries.Add(entry); // adds entries to journal 

    }

    


}