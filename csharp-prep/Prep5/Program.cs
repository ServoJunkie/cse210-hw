using System;

class Program
{
    //Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    //Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    //Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numberEntry = Console.ReadLine();
        int number = int.Parse(numberEntry);
        return number;
    }

    //Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int number)
    {
        int numberSquared = number * number;
        return numberSquared;
    }

    //Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string name, int numberSquared)
    {
        Console.WriteLine($"{name}, the square of your number is {numberSquared}");
    }
    static void Main(string[] args)
    {
        //Displays a welcome message.
        DisplayWelcome();
        
        //Asks for the user's name and favorite number and stores them in a string and int, respectively.
        string username = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        //Calculates the square of the user's favorite number.
        int numberSquared = SquareNumber(favoriteNumber);

        //Writes the user's name and the square of their favorite number to the terminal.
        DisplayResult(username, numberSquared);
    }
}