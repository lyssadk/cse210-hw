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
    public string GetActor2(){
        return _actor2;
    }
    public string GetName(){
        return _name;
    }
    
    public override void DetermineWinner(List<Player> players){
        // who ever guesses the movie first wins the points, whoever gets the most points overall gets a bonus
        foreach (Player player in players)
        {
            player.AddPoints(player.GetGameScore());
        }
        Console.WriteLine("Points have been added appropriately to all players.\nDisplay scores in main menu to see updated score.");
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

    public override void Begin(List<Player> players){
        movieFiler("movie.txt", _movies);
        int p = 0;
        int i = 0;
        int point = 100;
        int amountofTry = 1;
        while (p < players.Count()){
            foreach(Player player in players){
                player.SetGameScore(0);
                Console.WriteLine($"{player.GetName()}, What is the movie based of the following description?");
                if(i < _movies.Count()){
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine(_movies[i].GetDescription());
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Would you like a hint? (Type yes or if not type in name of movie you think it is)");
                    string userChoice = Console.ReadLine();
                    if (userChoice.ToLower() == "yes"){
                        Console.WriteLine($"Actor: {_movies[i].GetActor1()}");
                        point = 50;
                        amountofTry = 2;
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Enter name of movie or type yes for another actor");
                        userChoice = Console.ReadLine();
                        if(userChoice.ToLower() == "yes"){
                            Console.WriteLine($"Actor: {_movies[i].GetActor2()}");
                            point = point - 20;
                            amountofTry = 3;
                            Console.WriteLine("Enter name of movie");
                            userChoice = Console.ReadLine();
                            // make a method that reveals answer 
                        }

                    }
                    
                    if(userChoice.ToLower() == _movies[i].GetName().ToLower()) {
                    //make this a method that takes in a string (aka the user input yerrr)
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine($"Congrats, you nailed it. You get {point} points for getting it on the {amountofTry} try");
                        Console.WriteLine("    ");
                        Thread.Sleep(3000);
                        Console.Clear();
                        player.AddToGameScore(point);
                    }
                    else{
                        while(userChoice.ToLower() != _movies[i].GetName().ToLower()){
                            point -= 5;
                            amountofTry += 1;
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("Incorrect Guess. Type 'reveal' to give up or enter another guess");
                            userChoice = Console.ReadLine();
                            Congrats(player,point, userChoice, amountofTry, i);

                            if(userChoice.ToLower() == "reveal"){
                                Console.WriteLine("----------------------------------");
                                Console.WriteLine($"The movie was {_movies[i].GetName()}");
                                Console.WriteLine("----------------------------------");
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }
                        }

                    }
                    i+=1;
                }

                else{
                    i = 0;
                    Console.WriteLine("Not enough movies in database to continue");
                    Thread.Sleep(5000);
                    Console.Clear();
                }

                p += 1;
                DetermineWinner(players);
            }
        }
    }
    public void Congrats(Player player, int point, string userChoice, int amountofTry, int i){
        if(userChoice.ToLower() == _movies[i].GetName().ToLower()) {
            //make this a method that takes in a string (aka the user input yerrr)
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Congrats, you nailed it. You get {point} points for getting it in {amountofTry} guess(es)");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("    ");
            Thread.Sleep(3000);
            Console.Clear();
            
            player.AddToGameScore(point);
        }
    }
}
        


