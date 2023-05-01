public class Car{
// instances
public string brand; // these are empty rn
public int miles;
public string color;

// constructor (you dont always need one of these for smaller things) (this is simply how you declare but dont need it)
public Car(){

}

// methods (functions)
public void move_forward(){  // void means that it will return nothing, what you want to return in a function you define (sting int bool, etc)
    Console.WriteLine("is running"); 
}
public void display_card(){
    Console.WriteLine($"Brand = {brand} | Miles = {miles} | Color:{color}");
}
}