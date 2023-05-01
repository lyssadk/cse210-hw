using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Car bmw_m3 = new Car();
        bmw_m3.brand = "BMW";
        bmw_m3.miles = 123;
        bmw_m3.color = "Blue";
        
        bmw_m3.display_card();
    }
}