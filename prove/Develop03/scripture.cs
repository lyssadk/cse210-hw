public class Scripture{
    private string _scripture = "And I know that the record which I make is true; and I make it with mine own hand;\nand I make it according to my knowledge.";
    public void MakingWords(){
         string[] words = _scripture.Split(" ");
         
        foreach (var wordy in words)
        {    
            Word wordclass = new Word(wordy);
            foreach (char letter in wordy)
            {
                if (Char.IsLetter(letter)){
                    wordclass.NoPunc();
                }
                else {
                    wordclass.Punc();
                }
            }
            wordclass.Display();
         
        }
       
    }

    public void Display(){
        Console.WriteLine(_scripture);
    }
}

