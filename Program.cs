using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("What is your age?");
        string age = Console.ReadLine();                   
        Console.WriteLine("What is your eye color?");
        string eyeColor = Console.ReadLine();
        Console.WriteLine("What is your hair color?");
        string hairColor = Console.ReadLine();
        Console.WriteLine("What is your shoe size?");
        string shoeSize = Console.ReadLine();
        Console.WriteLine("What is your favorite color?");
        string color = Console.ReadLine();
        Console.WriteLine("What is your favorite tv show?");
        string tvShow = Console.ReadLine();
        Console.WriteLine("What is your favorite teacher?");
        string teacher = Console.ReadLine();
        Console.WriteLine("What is your favorite class?");
        string favoriteClass = Console.ReadLine();
        Console.WriteLine("What is your favorite holiday?");
        string holiday = Console.ReadLine();
        Console.WriteLine("What is your favorite season?");
        string season = Console.ReadLine();
        Console.WriteLine("What is your dream job?");
        string dreamJob = Console.ReadLine(); 
        Console.WriteLine("How many siblings do you have?");
        string siblings = Console.ReadLine();

        int Age = int.Parse(age);

        Console.Write("My Friends name is " + name + ". They are " + age + " old. They have " + eyeColor + " eyes and " + hairColor + "hair. Their shoe size is a size " 
        + shoeSize + ". Their favorite color is " + color + ". Their favorite tv show is " + tvShow + ". Their favorite teacher is " + teacher + " and their favorite class is " 
        + favoriteClass + ". Their favorite holiday is " + holiday + " and their favorite season is " + season + ". Their dream job is to be a " + dreamJob + ". They have " 
        + siblings + " siblings. " + "In five years they will be " + (Age+5) + " years old." );
    }
}