using System;

class Program
{
    static void Main(string[] args)
    {
        //  Word word = new Word("hello");
        // word.Display();
        Scripture scripture = new Scripture();
        Reference reference = new Reference("1 Nephi", 1, 3);
        scripture.MakingWords();
        scripture.Display();

       
    }
}