public class Word{
    private string _word;
    private bool _shown = true;

    private bool _hasPunc = false;

    private int _wordCount;
    public Word(string word, bool hasPunc){
        _word = word;
        _hasPunc = hasPunc;
    }

    public bool getPunc(){
        return _hasPunc;
    }

    public string getWord(){
        return _word;
    }
    //hide word for no punctuation

    public void NoPunc(){
        _wordCount = _word.Count();
        _word = "";
        
        for (int i = 0; i < _wordCount; i++)
        {
            _word += "_";
            _shown = false;
        }
    }

    //hide word for punctuations
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
        Console.Write($"{_word} ");
    }
}