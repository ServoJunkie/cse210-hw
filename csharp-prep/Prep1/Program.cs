using System;

class Program
{
    static void Main(string[] args)
    {
        //The next four lines write out requests to ask the user for their first and last names, and to store them in strings for later use.
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        //These next 2 lines write a blank line in the terminal, as well as a line that includes the strings obtained by the user.
        Console.WriteLine();
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}