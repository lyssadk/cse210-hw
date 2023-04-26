using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        int guess = -1;

        while (guess != number)
        {
             Console.WriteLine($"What is the magic number? {number}");
        Console.WriteLine("What is your guess?");
            string answer = Console.ReadLine();
            int response = int.Parse(answer);
    
           if (response < number)
           {
            Console.WriteLine("Higher");
           }

           else if (response > number)
            {
            Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("you got it!");
            }
        }
        
    }
}