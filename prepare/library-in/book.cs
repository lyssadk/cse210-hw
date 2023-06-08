public class Book : Loanable{
    private int _upc;
    private string _isbn;
    private string _title;

    // public Book(): base(){
    // }
    
    public Book(string title,  string isbn, int upc){
        _title = title;
        _isbn = isbn;
        _upc = upc;
    }

    public void ShowBookDetails(){
        Console.WriteLine($"Title: {_title} || ISBN: {_isbn} || UPC:{_upc}");
    }

    public override void Display()
    {
        base.Display(); 
        ShowBookDetails();
    }
}