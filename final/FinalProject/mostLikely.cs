public class MostLikelyTo : Game {

    // enter player names, and ask if they want our preloaded most likely to prompts, or if they want their own
    // the winner is whoever is voted the most overall 
    // keeps track of which ones everyone gets and displays them at the end if the user wants to
    
    public override Player DetermineWinner(){
        return _winner;
    }
}