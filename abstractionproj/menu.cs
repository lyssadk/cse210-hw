public class Menu{

    public Menu(){

    }

    Journal journal = new Journal();

    public void newEntry(){
        Entry entry = new Entry();
        Console.WriteLine(entry.prompt);
        Console.WriteLine("Please write your entry:");
        entry.entry = Console.ReadLine();

        journal.entries.Add(entry);

    }


}