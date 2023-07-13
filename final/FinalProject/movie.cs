public class Movie : Game {
 // this would involve a text to speech where it would actually speak the random words wow.

    private string _name;
    private int _year;
    private int _minutes;
    
    private List<string> _actors;
    private string _description;

    private List<Movie> _movies;

    public Movie(string name, int year, int minutes, string description) : base() {
        _name = name;
        _year = year; 
        _minutes = minutes;
        _description = description;
    }

    public Movie():base(){

    }
    
    public string GetDescription(){
        return _description;
    }
    public List<Movie> GetMovies(){
        return _movies;
    }
    public string GetName(){
        return _name;
    }
    public override void Begin(List<Player> players){

        //ask them to guess the movie title based on description, and they can get hints with the actors in it and the year it was produced.

    }
    public override void DetermineWinner(List<Player> players){
        // who ever guesses the movie first wins the points, whoever gets the most points overall gets a bonus
    }

        
     public void movieFiler(string filename, List<Movie> list){
        string[] lines = System.IO.File.ReadAllLines(filename);
        int i = 0;
        foreach (string line in lines)
        {   
            Console.WriteLine("begin");
            string[] parts1 = lines[i].Split('|');
            string [] parts2 = parts1[0].Split(',');
            _description = parts1[1];
            _name = parts2[0];
            _minutes = int.Parse(parts2[2]);
            _year = int.Parse(parts2[1]);
            // _actors.Add(parts2[3]);
            // _actors.Add(parts2[4]);
            
            Movie movie = new Movie(_name,_year,_minutes,_description);
            Console.WriteLine(movie.GetDescription());
            Console.WriteLine(movie.GetName());
            
        }
    }

}
        



