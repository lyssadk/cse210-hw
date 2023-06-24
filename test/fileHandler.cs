public class fileHandler{
    private string _filename;
    private Person user;
    List<Goal> goals = new List<Goal>();
    public fileHandler(string filename){
        _filename = filename;
    }
    public void LoadingGoals(string filename, string username, string password){
        try
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            string[] line1 = lines[0].Split(',');
            if(line1[0] == password){
                password = line1[0];
                string levelName = line1[1];
                int score = int.Parse(line1[2]);
                int trees = int.Parse(line1[3]);
                user = new Person(username, password, score, levelName, trees);
                // List<Goal> goals = user.GetList();
                foreach (string line in lines.Skip(1))
                {
                    string[] parts = line.Split(":");

                    string goalType = parts[0];
                    string[] parts2 = parts[1].Split(",");
                    if (goalType == "simple"){
                        string title = parts2[0];
                        string description = parts2[1];
                        int points = int.Parse(parts2[2]);
                        int difficulty = int.Parse(parts2[3]);
                        bool complete = bool.Parse(parts2[4]);

                        Simple simple = new Simple(title, description, points, difficulty, complete);
                        goals.Add(simple);

                    }

                    else if(goalType == "checklist"){
                        string title = parts2[0];
                        string description = parts2[1];
                        int points = int.Parse(parts2[2]);
                        int difficulty = int.Parse(parts2[3]);
                        int checklistLeft = int.Parse(parts2[4]);
                        int checklistAmount = int.Parse(parts2[5]);
                        int bonus = int.Parse(parts2[6]);
                        bool complete = bool.Parse(parts2[7]);

                        Checklist check = new Checklist(title, description, points, difficulty, checklistLeft, checklistAmount, bonus, complete);
                        goals.Add(check);
                    }

                    else if(goalType == "eternal"){
                        string title = parts2[0];
                        string description = parts2[1];
                        int points = int.Parse(parts2[2]);
                        int difficulty = int.Parse(parts2[3]);
            
                        Eternal eternal = new Eternal(title, description, points, difficulty);
                        goals.Add(eternal);
                    }
                }
            }
        }
        catch (System.Exception)
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine(password);
            }
            user = new Person(username, password);

            
        }
    }

    public void SaveGoals(string filename){
       // using (StreamWriter) // how do i output to a file that exists
    }

    public List<Goal> GetGoals(){
        return goals;
    }

    public Person GetPerson(){
        return user;  // how do i do this? #thnx // would i need another constructor in the person class that is empty and allows you to change the info later on? How does that work?
    }
}