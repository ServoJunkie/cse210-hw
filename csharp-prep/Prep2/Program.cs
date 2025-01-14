using System;

class Program
{
    static void Main(string[] args)
    {
        //This block of code asks the user for their grade percentage, stores their response, and converts it to a float.
        Console.Write("Please enter you grade percentage: ");
        string gradePercentage = Console.ReadLine();
        float numberPercentage = int.Parse(gradePercentage);
        Console.WriteLine();

        //This code defines 'letter' as a string variable, sets it equal to the proper letter depending on the user's percentage, and 
        //writes it to the terminal.
        string letter;
        if (numberPercentage >= 90)
            {
                letter = "A";
            }
        else if (numberPercentage >= 80)
            {
                letter = "B";
            }
        else if (numberPercentage >= 70)
            {
                letter = "C";
            }
        else if (numberPercentage >= 60)
            {
                letter = "D";
            }
        else
            {
                letter = "F";
            }
        Console.WriteLine($"Your letter grade is {letter}");
        
        //This if-else statement writes a statement declaring whether the user has passed the course.
        if (numberPercentage >= 70)
            {
                Console.WriteLine("You have passed the course!");
            }
        else
            {
                Console.WriteLine("You did not pass the course. Please try again! I know you can do better next time!");
            }
    }
}