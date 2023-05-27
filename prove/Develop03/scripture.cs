public class Scripture{
    private string _scripture = "And I know that the record which I make is true; and I make it with mine own hand;\nand I make it according to my knowledge.";
    Reference reference = new Reference("1 Nephi", 1, 3);
    private List<Word> _wordlist = new List<Word>();
    private List<int> _intlist = new List<int>();

    public Scripture(){
         string[] words = _scripture.Split(" ");
         int counter = 0;
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

            _intlist.Add(counter);
            counter += 1;
        }
    }

    public void Display(){
        foreach (Word word in _wordlist)
        {
            word.Display();
        }
        Console.WriteLine();
    }

    public int HideRandomWord(){

        for (int i = 0; i < 4; i++)
        {
            
            int randomNumber = RandomNum();
            string tempWord = _wordlist[randomNumber].getWord();
            Console.Clear();
            // _wordlist[randomNumber].NoPunc();
            if (_intlist.Count != 0){
                if (!_wordlist[_intlist[randomNumber]].getPunc()){
                    _wordlist[_intlist[randomNumber]].NoPunc();
                    

                }
                else{
                    _wordlist[_intlist[randomNumber]].Punc();

                }

                _intlist.RemoveAt(randomNumber);
            }
            else{
                return 1;
            }
        }
        return 0;
    }

    public int RandomNum(){
        var random = new Random();
        return random.Next(_intlist.Count);
    }
}

