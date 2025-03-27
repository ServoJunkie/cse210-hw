using System;

class Program
{
    static void Main(string[] args)
    {
        bool allVersesAcquired = false;
        bool quitting = false;
        List<Scripture> _scriptures = new List<Scripture>();

        do
        {
            Console.Clear();

            Console.WriteLine("Type 'new scripture' to input a new scripture or press enter to continue:");
            string userInput = Console.ReadLine();

            if (userInput == "new scripture")
            {            
                Console.WriteLine("Please enter the scripture reference:");
                string reference = Console.ReadLine();

                Console.WriteLine("Please enter the text in the following format:");
                Console.WriteLine("1 xxxx xxxx xxxx xxxxx. 2 xxxxx xxx xx xxxxxx, xxxx xxxx.");
                string text = Console.ReadLine();

                Scripture newScripture = new Scripture(reference, text);
                _scriptures.Add(newScripture);
            }
            else if (string.IsNullOrEmpty(userInput))
            {
                allVersesAcquired = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again");
            }
        } while(allVersesAcquired == false);


        Console.WriteLine("Please enter the number of the scripture you would like to memorize (First scripture = 1, second scripture = 2, etc.)");
        int scriptureNumber = int.Parse(Console.ReadLine()) - 1;
        Scripture currentScripture = _scriptures[scriptureNumber];

        do
        {
            Console.Clear();
            currentScripture.DisplayScripture();

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                quitting = true;
            }
            else if (currentScripture.IsHidden())
            {
                quitting = true;
            }
            else if (string.IsNullOrEmpty(userInput))
            {
                currentScripture.HideWord();
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again");
            }
        } while(quitting == false);
    }


    public void IsFinished()
    {

    }

    public void HideWords()
    {

    }
}