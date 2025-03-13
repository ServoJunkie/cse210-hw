using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> _scriptures = new List<Scripture>();

        bool quitting = false;

        do
        {
            Console.Clear();

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                quitting = true;
            }
        } while(quitting == false);
    }
}