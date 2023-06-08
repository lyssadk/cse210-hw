public class Loanable{
    private bool _isCheckedin = true;

    public void Checkout(){
        _isCheckedin = false;
    }

    public void CheckIn(){
        _isCheckedin = true;   
    }

    public virtual void Display(){
        Console.WriteLine($"Available: {_isCheckedin}");
    }

}