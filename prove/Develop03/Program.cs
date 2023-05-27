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
            scripture.HideRandomWord();
            
            if (input == "quit")
            {
                break;
            }


        }


        

       
    }
}