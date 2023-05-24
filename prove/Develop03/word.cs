public class Word{
    private string _word;
    private bool _shown = true;

    private int _wordCount;
    public Word(string word){
        _word = word;
    }

     public Word(){
        _word = "hello";
    }


    public void NoPunc(){
        _wordCount = _word.Count();
        _word = "";
        
        for (int i = 0; i < _wordCount; i++)
        {
            _word += "_";
            _shown = false;
        }
    }
      public void Punc(){
        _wordCount = _word.Count()-1;
        _word = "";
        
        for (int i = 0; i < _wordCount; i++)
        {
            _word += "_";
            _shown = false;
        }
    }
    public void Display(){
        Console.WriteLine($"{_word} Shown: {_shown}");
    }
}