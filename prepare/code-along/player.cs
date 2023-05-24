public class Player{
    private string _name;
    private int _jersey;
    private string _position = "";

    public Player(string name, int jersey){
        _name = name;
        _jersey = jersey;
    }
      public Player(string name, int jersey, string position){
        _name = name;
        _jersey = jersey;
        _position = position;
    }


    public void SetPosition(string position){
        _position = position;
    }

    public string Display(){
        return $"{_name} #{_jersey}, {_position}";
    }
}