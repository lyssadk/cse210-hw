public class Scripture{
    private string _scripture = "And I know that the record which I make is true; and I make it with mine own hand;\nand I make it according to my knowledge.";
    Reference reference = new Reference("1 Nephi", 1, 3);
    private List<Word> _wordlist = new List<Word>();

    public Scripture(){
         string[] words = _scripture.Split(" ");
         
        foreach (var wordy in words)
        {    
            bool hasPunc = false;
            foreach (char w in wordy){
                if (!Char.IsLetter(w)){
                    hasPunc = true;
                }
                else{
                    hasPunc = false;
                }
            }

            Word wordclass = new Word(wordy, hasPunc);
            _wordlist.Add(wordclass);
        }
    }

    public void Display(){
        foreach (Word word in _wordlist)
        {
            word.Display();
        }
    }

    public void HideRandomWord(){
        int randomNumber = RandomNum();
        string tempWord = _wordlist[randomNumber].getWord();
        Console.Clear();
        // _wordlist[randomNumber].NoPunc();

        if (!_wordlist[randomNumber].getPunc()){
            _wordlist[randomNumber].NoPunc();

        }
        else{
            _wordlist[randomNumber].Punc();

        }
    }

    public int RandomNum(){
        var random = new Random();
        return random.Next(_wordlist.Count);
    }
}

