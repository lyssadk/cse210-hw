using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        
        while(true){
            scripture.Display();
            Console.WriteLine("Hit enter to hide a word or type quit to stop");
            string input = Console.ReadLine();
            int maybeExit = scripture.HideRandomWord();
            
            if (input == "quit" || maybeExit == 1)
            {
                scripture.Display();
                Console.WriteLine("Thanks for using this program");
                break;
            }


        }


        

       
    }
}