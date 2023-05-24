public class Reference{
private string _book;
private int _startVerse;
private int _endVerse;
private int _chapter;

public Reference(string book, int chapter, int startVerse){
    Console.WriteLine($"{book} {chapter}:{startVerse}");
    _book = book;
    _chapter = chapter;
    _startVerse = startVerse;
}

public Reference(string book, int chapter, int startVerse, int endVerse){
    Console.WriteLine($"{book} {chapter}:{startVerse}-{endVerse}");
    _book = book;
    _chapter = chapter;
    _startVerse = startVerse;
    _endVerse = endVerse;
}

public Reference(){

}

}