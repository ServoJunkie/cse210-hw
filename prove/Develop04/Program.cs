using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int amountOfBreathingActivitiesCompleted = 0;
        int amountOfReflectingActivitiesCompleted = 0;
        int amountOfListingActivitiesCompleted = 0;
        int totalAmountOfActivitiesCompleted = 0;

        bool finished = false;
        
        while (finished == false)
        {
            Console.Clear();
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
                Console.WriteLine();
                Console.WriteLine(currentBreathingActivity.GetStartingMessage());
                Thread.Sleep(500);
                currentBreathingActivity.DisplayIntro();
                int timeChosen = int.Parse(Console.ReadLine());
                currentBreathingActivity.SetTime(timeChosen);
                Console.Clear();
                currentBreathingActivity.DisplayBreathingCountdown();
                Console.WriteLine();
                Console.WriteLine(currentBreathingActivity.GetEndingMessage());
                Thread.Sleep(1500);

                amountOfBreathingActivitiesCompleted ++;
                totalAmountOfActivitiesCompleted ++;
            }
            else if (userChoice == "2")
            {
                ReflectionActivity currentReflectionActivity = new ReflectionActivity();
                Console.WriteLine();
                Console.WriteLine(currentReflectionActivity.GetStartingMessage());
                Thread.Sleep(500);
                currentReflectionActivity.DisplayIntro();
                int timeChosen = int.Parse(Console.ReadLine());
                currentReflectionActivity.SetTime(timeChosen);
                Console.Clear();
                Console.WriteLine("Consider the following prompt:");
                Console.WriteLine();
                Console.WriteLine($" --- {currentReflectionActivity.GetPrompt()} --- ");
                Console.WriteLine();
                currentReflectionActivity.DisplayCountdown();
                currentReflectionActivity.DisplayQuestions();
                Console.WriteLine();
                Console.WriteLine(currentReflectionActivity.GetEndingMessage());
                Thread.Sleep(1500);

                amountOfReflectingActivitiesCompleted ++;
                totalAmountOfActivitiesCompleted ++;
            }
            else if (userChoice == "3")
            {
                ListingActivity currentListingActivity = new ListingActivity();
                Console.WriteLine();
                Console.WriteLine(currentListingActivity.GetStartingMessage());
                Thread.Sleep(500);
                currentListingActivity.DisplayIntro();
                int timeChosen = int.Parse(Console.ReadLine());
                currentListingActivity.SetTime(timeChosen);
                Console.Clear();
                currentListingActivity.Countdown();
                Console.WriteLine();
                Console.WriteLine(currentListingActivity.GetEndingMessage());
                Thread.Sleep(1500);

                amountOfListingActivitiesCompleted ++;
                totalAmountOfActivitiesCompleted ++;
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

        Console.Clear();
        Console.WriteLine("Nice job! You completed:");
        Console.WriteLine($"- {amountOfBreathingActivitiesCompleted} breathing activites");
        Console.WriteLine($"- {amountOfReflectingActivitiesCompleted} reflecting activites");
        Console.WriteLine($"- {amountOfListingActivitiesCompleted} listing activites");
        Console.WriteLine($"- {totalAmountOfActivitiesCompleted} total activites");
    }
}