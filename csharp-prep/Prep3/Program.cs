using System;

class Program
{
    static void Main(string[] args)
    {
        //First, we generate a random number for the user to guess.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        //We set a boolean variable in order to detect if the user has guessed correctly.
        bool guessedCorrectly = false;

        //This code asks for the user to input a guess and compares it to the magic number. It will loop until the user guesses correctly.
        do
        {
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            int guess = int.Parse(guessInput);

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                guessedCorrectly = true;
            }
        } while (guessedCorrectly == false);
    }
}