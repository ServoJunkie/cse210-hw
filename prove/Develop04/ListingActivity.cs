public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

    public ListingActivity()
    {
        SetTypeOfActivity("Listing");
        SetActivityDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public string GetPrompt()
    {
        int _AmountOfPrompts = _prompts.Count();
        
        Random randomGenerator = new Random();
        int currentPromptNumber = randomGenerator.Next(0, _AmountOfPrompts);
        string currentPrompt = _prompts[currentPromptNumber];
        return (currentPrompt);
    }

    public void Countdown()
    {
        int amountOfAnswers = 0;
        int time = GetTime();
        
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        string currentPrompt = GetPrompt();
        Console.WriteLine($" --- {currentPrompt} ---");
        Console.WriteLine();
        Console.Write("You may begin in:  ");
        
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine("Begin!");

        DateTime startTime = DateTime.Now;
        DateTime finishedTime = startTime.AddSeconds(time);

        while (paused == true)
        {
            Console.ReadLine();
            amountOfAnswers ++;

            DateTime currentTime = DateTime.Now;
            if (currentTime >= finishedTime)
            {
                Console.WriteLine();
                Console.WriteLine($"You listed {amountOfAnswers} items!");
                paused = false;
            }
        }
    }
}