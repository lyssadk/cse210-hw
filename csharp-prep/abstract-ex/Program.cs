// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Book mistborn = new Book("Mistborn", "Brandon Sanderson");
Book hp = new Book("Harry Potter and The Goblet of Fire", "J.K. Rowling");

mistborn.Display();
hp.Display();

Console.WriteLine(mistborn.isAvailable());