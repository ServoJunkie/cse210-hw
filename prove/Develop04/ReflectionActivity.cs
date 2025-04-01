public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>{"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private List<string> _questions = new List<string>{"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    public ReflectionActivity()
    {
        SetTypeOfActivity("Reflecting");
        SetActivityDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public string GetPrompt()
    {
        int _AmountOfPrompts = _prompts.Count();
        
        Random randomGenerator = new Random();
        int currentPromptNumber = randomGenerator.Next(0, _AmountOfPrompts);
        string currentPrompt = _prompts[currentPromptNumber];
        return (currentPrompt);
    }

    public void DisplayCountdown()
    {
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        Console.Write("5");
        Thread.Sleep(1000);
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
    }

    public void DisplaySpinner()
    {
        int countdown = 16;
        while (countdown != 0)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("—");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write(@"\");
            Thread.Sleep(500);
            Console.Write("\b \b");

            countdown = countdown - 2;
        }
    }

    public void DisplayQuestions()
    {
        int time = GetTime();
        DateTime startTime = DateTime.Now;
        DateTime finishedTime = startTime.AddSeconds(time);
        
        while (paused == true)
        {
            Console.WriteLine();

            int _AmountOfQuestions = _prompts.Count();

            Random randomGenerator = new Random();
            int currentQuestionNumber = randomGenerator.Next(0, _AmountOfQuestions);
            string currentQuestion = _questions[currentQuestionNumber];
            Console.WriteLine($"{currentQuestion}" );

            DisplaySpinner();
            Console.WriteLine();

            DateTime currentTime = DateTime.Now;
            if (currentTime >= finishedTime)
            {
                paused = false;
            }
        }
    }
}