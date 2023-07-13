using System;


class Program
{
    static void Main(string[] args)
    {
        Movie movie  = new Movie();
        
        movie.movieFiler("movie.txt", movie.GetMovies());
        Menu menu = new Menu();
        menu.display();

        // dice roll feature 
    }
}