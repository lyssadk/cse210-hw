public class Movie : Game {
 // this would involve a text to speech where it would actually speak the random words wow.

    private string _name;
    private int _year;
    private int _minutes;
    
    private string _actor1;
    private string _actor2;
    
    private string _description;

    private List<Movie> _movies = new List<Movie>();

    public Movie(string name, int year, int minutes, string description, string actor1, string actor2) : base() {
        _name = name;
        _year = year; 
        _minutes = minutes;
        _description = description;
        _actor1 = actor1;
        _actor2 = actor2;
    }

    public Movie():base(){

    }
    
    public string GetDescription(){
        return _description;
    }

    public string GetActor1(){
        return _actor1;
    }

    public List<Movie> GetMovies(){
        return _movies;
    }
    public string GetName(){
        return _name;
    }
    public override void Begin(List<Player> players){
        movieFiler("movie.txt", _movies);
        int p = 0;
        int i = 0;
        while (p < players.Count()){
            foreach(Player player in players){
                Console.WriteLine($"{player.GetName()}, What is the movie based of the following description?");
                if(i < _movies.Count()){
                    Console.WriteLine(_movies[i].GetDescription());
                    Console.WriteLine("Would you like to know the actors?");
                    string userChoice = Console.ReadLine();
                    if (userChoice.ToLower() == "yes"){
                        Console.WriteLine(_movies[i].GetActor1());
                    }
                    i+=1;
                }
                else{
                    i = 0;
                    Console.WriteLine("Not enough movies in database to continue, repeating");
                    Console.WriteLine(_movies[i].GetDescription());
                }
                p += 1;
            }
        }
        //ask them to guess the movie title based on description, and they can get hints with the actors in it and the year it was produced.

    }

    
    public override void DetermineWinner(List<Player> players){
        // who ever guesses the movie first wins the points, whoever gets the most points overall gets a bonus
    }

        
     public List<Movie> movieFiler(string filename, List<Movie> list){
        string[] lines = System.IO.File.ReadAllLines(filename);
        int i = 0;
        foreach (string line in lines)
        {   
            string[] parts1 = lines[i].Split('|');
            string [] parts2 = parts1[0].Split(',');
            _description = parts1[1];
            _name = parts2[0];
            _minutes = int.Parse(parts2[2]);
            _year = int.Parse(parts2[1]);
            _actor1 = parts2[3];
            _actor2 = parts2[4];
            
            Movie movie = new Movie(_name, _year, _minutes, _description, _actor1, _actor2);
            list.Add(movie);

            i+=1;
            
        }

        return list;
    }

}
        



