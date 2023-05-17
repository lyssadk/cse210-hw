public class Journal {
    public Journal(){

    }

    public List<Entry> entries = new List<Entry>();

    // now we need a method to display the entries when the users ask for that option
    public void displayEntry(){
        foreach ( Entry entry in entries)
        {
           Console.WriteLine($"{entry.entry} {entry.date} {entry.prompt}");
            
       }
   }

   public void saveEntry(){
        string fileName = "myFile.txt";
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            foreach (Entry entry in entries)
            { 
                outputFile.WriteLine($"{entry.date}|{entry.prompt}|{entry.entry}");
            }
        }
   }

   public void loadEntry(){
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            

            Entry entry1 = new Entry();
            entry1.entry = parts[2];
            entry1.date = parts[0];
            entry1.prompt = parts[1];

            entries.Add(entry1);
        }
   }

}