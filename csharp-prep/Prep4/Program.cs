using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        // List<string> words = new List<string>(); // declares a variable and creates a new one
        // anytime we use () ut creates a new object
        //words.Add("phone");
       // words.Add("Keyboard");
       // Console.WriteLine(words.Count);
       // foreach (string word in words){
       //     Console.WriteLine(word);
       // }
        //for (int i = 0; i < words.Count; i++)
        //{
       //      Console.WriteLine(words[i]);
        //}
        int zero = -1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        // do-while loop to add numbers to list from the user
        do
        {
            Console.Write("Enter a number: ");
            string response = Console.ReadLine();
            zero = int.Parse(response);
            numbers.Add(zero);

        } while (zero !=0);

        // when they enter 0
        //SUM
        int sum = 0; // making a variable for sum

        // for each loop that adds each number to the sum (0->)
        foreach (int number in numbers)
        {
            sum+=number;
        }

        Console.Write($"The sum is {sum}. ");

        // AVERAGE
        float average = ((float)sum)/ numbers.Count;
         

     }
}