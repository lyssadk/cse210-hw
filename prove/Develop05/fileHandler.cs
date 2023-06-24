public class fileHandler{
    List<Goal> goals = new List<Goal>();
    private string _filename;
    private string _username;
    private string _password;
    private Person _user;
    // why fo i need a seperate text thing and not a list?? je suis tres confused

    public List<Goal> Load(){
        try{
            while (true)
            {
                Console.WriteLine("Please Enter Your Name:");
                _username = Console.ReadLine();
                Console.WriteLine("Enter password:");
                _password = Console.ReadLine(); 
                _filename = $"{_username}.txt";

                string[] lines = System.IO.File.ReadAllLines(_filename);
                string[] line1 = lines[0].Split(',');
                if(line1[0] == _password){
                    string levelName = line1[1];
                    int score = int.Parse(line1[2]);
                    int trees = int.Parse(line1[3]);
                    _user = new Person(_username, _password, score, levelName, trees);

                    foreach (string line in lines.Skip(1))
                    {
                        string[] parts = line.Split(":");
                        string[] parts2 = parts[1].Split(",");

                        string goalType = parts[0];
                        
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
                    break;
                }
                else{
                    Console.WriteLine("Password is WRONG! loser.");
                }
            }
        }
        catch (System.Exception)
        {
            using (StreamWriter outputFile = new StreamWriter(_filename))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine(_password);
            }
            _user = new Person(_username, _password);
        }
        return goals;
    }

    public string GetFileName(){
        return _filename;
    }
    public Person getUser(){
        return _user;
    }
}