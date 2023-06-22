public class fileHandler{
    private string _fileName = "default.txt";
    private List<Goal> goals = new List<Goal>(); // je suis tres confused

    public fileHandler(string filename){
        _fileName = filename;
    }

    public void Load(string filename){

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string _goalType = parts[0];
            string _description = parts[1];
            string _title = parts[2];
            int _points = int.Parse(parts[3]);
            int _difficulty = int.Parse(parts[4]);

        }
    }

}