using System;

public class Program
{   
    
    static string name;
    static string age;
    static string eyeColor;
    static string hairColor;
    static string shoeSize;
    static string favoriteColor;
    static string favoriteTVorMovie;
    static string favoriteTeacher;
    static string favoriteClass;
    static string favoriteHoliday;
    static string favoriteSeason;
    static string dreamJob;
    static string numberOfSiblings;
    static int futureAge;

    public static void Main(string[] args)
    {
        Console.Clear();

        AskName();
        AskAge();
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        AskFavoriteColor();
        AskFavoriteTvShow();
        AskFavoriteTeacher();
        AskFavoriteClass();
        AskFavoriteHoliday();
        AskFavoriteSeason();
        AskDreamJob();
        CalculateAgeIn5Years(age);
        AskNumberOfSiblings();
        DisplaySummaryMessage();    
    }

    public static void AskName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
    }
    public static void AskAge()
    {
        Console.WriteLine("What is your age?");
        age = Console.ReadLine();   
    }
    public static void AskEyeColor()
    {
        Console.WriteLine("What is your eye color?");
        eyeColor = Console.ReadLine();
    }
    public static void AskHairColor()
    {
        Console.WriteLine("What is your hair color?");
        hairColor = Console.ReadLine();
    }
    public static void AskShoeSize()
    {
         Console.WriteLine("What is your shoe size?");
        shoeSize = Console.ReadLine();
    }
    public static void AskFavoriteColor()
    {
        Console.WriteLine("What is your favorite color?");
        favoriteColor = Console.ReadLine();
    }
    public static void AskFavoriteTvShow()
    {
        Console.WriteLine("What is your favorite tv show?");
        favoriteTVorMovie = Console.ReadLine();
    }
    public static void AskFavoriteTeacher()
    {
         Console.WriteLine("What is your favorite teacher?");
        favoriteTeacher = Console.ReadLine();
    }
    public static void AskFavoriteClass()
    {
         Console.WriteLine("What is your favorite class?");
        favoriteClass = Console.ReadLine();
    }
    public static void AskFavoriteHoliday()
    {
        Console.WriteLine("What is your favorite holiday?");
        favoriteHoliday = Console.ReadLine();
    }
    public static void AskFavoriteSeason()
    {
         Console.WriteLine("What is your favorite season?");
        favoriteSeason = Console.ReadLine();
    }
    public static void AskDreamJob()
    {
         Console.WriteLine("What is your dream job?");
        dreamJob = Console.ReadLine(); 
    }
    public static void CalculateAgeIn5Years(string age){
        int Age = int.Parse(age);
        futureAge = (Age + 5);
    }
    public static void AskNumberOfSiblings()
    {
        Console.WriteLine("How many siblings do you have?");
        numberOfSiblings = Console.ReadLine();
    }
    public static void DisplaySummaryMessage()
    {
        Console.Write("My Friends name is " + name + ". They are " + age + " old. They have " + eyeColor + " eyes and " + hairColor + " hair. Their shoe size is a size " 
        + shoeSize + ". Their favorite color is " + favoriteColor + ". Their favorite tv show is " +  favoriteTVorMovie + ". Their favorite teacher is " + favoriteTeacher + " and their favorite class is " 
        + favoriteClass + ". Their favorite holiday is " + favoriteHoliday + " and their favorite season is " + favoriteSeason + ". Their dream job is to be a " + dreamJob + ". They have " 
        + numberOfSiblings + " siblings. " + "In five years they will be " + futureAge + " years old." );
    }

}