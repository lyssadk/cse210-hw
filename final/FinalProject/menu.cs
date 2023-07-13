public class Menu{
    private int userChoice;
    
    private List<Player> players = new List<Player>();
    private TruthOrDare truthOrDare = new TruthOrDare();
    private MostLikelyTo mostLikelyTo = new MostLikelyTo();
    private Movie movie = new Movie();
    
    public void display(){
        Console.WriteLine("--------------------------");
        Console.WriteLine("        LETS PARTY      ");
        Console.WriteLine("--------------------------");
        Console.WriteLine("");
        Console.WriteLine("Begin by entering player names.");
        GetPlayers(players);
        
        while (true){
            Console.WriteLine("Select an option below:\n1. Most Likely To\n2. Truth or Dare\n3. Guess the movie\n4. Add player\n5. Remove Player\n6. Display Scores\n7. Quit");
            userChoice = int.Parse(Console.ReadLine());
            Console.Clear();

            if(userChoice == 1){
                mostLikelyTo.Begin(players);
            }
            else if(userChoice == 2){
                truthOrDare.Begin(players);
            }
            else if(userChoice == 3){
                movie.Begin(players);
            }
            else if(userChoice == 4){
                GetPlayers(players);

            }
            else if(userChoice == 5){
                int i = 1;
                foreach (Player player in players)
                {
                    Console.WriteLine($"{i}. {player.GetName()}");
                    i += 1;
                }

                Console.WriteLine($"Which player would you like to remove (1 - {players.Count})?");
                int remove = int.Parse(Console.ReadLine()) - 1; 
                players.RemoveAt(remove);

            }
            else if(userChoice == 6){
                Console.Clear();
                Console.SetCursorPosition((Console.WindowWidth / 2) - 6, Console.CursorTop);
                Console.WriteLine($"PLAYER| SCORE");
                foreach(Player player in players){
                    Console.SetCursorPosition((Console.WindowWidth / 2) - player.GetName().Count(), Console.CursorTop);
                   Console.WriteLine($"{player.GetName().ToUpper()} | {player.GetScore()}");
                }

            }
             else if(userChoice == 7){
                break;
            }
           
        }
    }

    public List<Player> GetPlayers(List<Player> players){
        Console.WriteLine("Enter player names, type 'done' when all players have been added.");

        while (true)
        {
            string player = Console.ReadLine() ?? string.Empty;
            
            if(player == "done"){
                break;
            }
            else if(player == ""){

            }
            else{
                Player playerL = new Player(player);
                players.Add(playerL);
            }
            
            
        }
        return players;
    }
}