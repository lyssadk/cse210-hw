public class fileHandler{
    public void filer(List<string> list, string filename){
        string[] lines = System.IO.File.ReadAllLines(filename);
        // how would i grab random lines and only add those ones?
        foreach (string line in lines)
        {
            list.Add(line);
        }
    }
    

}