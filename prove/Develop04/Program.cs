using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        bool finished = false;
        
        while (finished == false)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                BreathingActivity currentBreathingActivity = new BreathingActivity();
                Console.WriteLine(currentBreathingActivity.GetStartingMessage());
                currentBreathingActivity.DisplayIntro();
                int timeChosen = int.Parse(Console.ReadLine());
                currentBreathingActivity.SetTime(timeChosen);
                Console.Clear();
                currentBreathingActivity.DisplayBreathingCountdown();
                Console.WriteLine(currentBreathingActivity.GetEndingMessage());
            }
            else if (userChoice == "2")
            {
                ReflectionActivity currentReflectionActivity = new ReflectionActivity();
                Console.WriteLine(currentReflectionActivity.GetStartingMessage());
                currentReflectionActivity.DisplayIntro();
                int timeChosen = int.Parse(Console.ReadLine());
                currentReflectionActivity.SetTime(timeChosen);
                Console.Clear();
                Console.WriteLine(currentReflectionActivity.GetPrompt());
                currentReflectionActivity.DisplayQuestions();
                Console.WriteLine(currentReflectionActivity.GetEndingMessage());
            }
            else if (userChoice == "3")
            {
                ListingActivity currentListingActivity = new ListingActivity();
                Console.WriteLine(currentListingActivity.GetStartingMessage());
                currentListingActivity.DisplayIntro();
                int timeChosen = int.Parse(Console.ReadLine());
                currentListingActivity.SetTime(timeChosen);
                Console.Clear();
                Console.WriteLine(currentListingActivity.GetPrompt());
                currentListingActivity.Countdown();
                Console.WriteLine(currentListingActivity.GetEndingMessage());
            }
            else if (userChoice == "4")
            {
                finished = true;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}