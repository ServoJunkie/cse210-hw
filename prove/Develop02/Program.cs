using System;

class Program
{
    static void Main(string[] args)
    {
        Menu mainMenu = new Menu();

        Journal myJournal = new Journal();

        PromptManager promptManager1 = new PromptManager();

        bool finished = false;

        mainMenu.DisplayWelcome();
        do
        {
            mainMenu.DisplayMainMenu();

            string menuChoice = Console.ReadLine();
            int menuChoiceInt = int.Parse(menuChoice);

            if (menuChoiceInt == 1)
            {
                DateTime theCurrentTime = DateTime.Now;
                string currentDate = theCurrentTime.ToShortDateString();
                
                Console.Write("Please enter your name: ");
                string currentUsername = Console.ReadLine();

                string currentPrompt = promptManager1.GetRandomPrompt();
                Console.WriteLine(currentPrompt);

                string currentText = Console.ReadLine();

                Entry currentEntry = new Entry();
                currentEntry._username = currentUsername;
                currentEntry._date = currentDate;
                currentEntry._prompt = currentPrompt;
                currentEntry._text = currentText;

                myJournal.AddEntry(currentEntry);
            }
            else if (menuChoiceInt == 2)
            {
                myJournal.DisplayEntries();
            }
            else if (menuChoiceInt == 3)
            {
                Console.WriteLine("Please enter the name of the file you wish to access:");
                string fileName = Console.ReadLine();

                myJournal.Load(fileName);
            }
            else if (menuChoiceInt == 4)
            {
                Console.WriteLine("Please enter the name of the file you wish to access:");
                string fileName = Console.ReadLine();

                myJournal.Save(fileName);
            }
            else if (menuChoiceInt == 5)
            {
                finished = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        } while (finished == false);
    }
}