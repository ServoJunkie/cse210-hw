public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetTypeOfActivity("Breathing");
        SetActivityDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }
    
    
    
    public void DisplayBreathingCountdown()
    {
        int time = GetTime();
        DateTime startTime = DateTime.Now;
        DateTime finishedTime = startTime.AddSeconds(time);
        
        while (paused == true)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
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

            Console.WriteLine();
            Console.Write("Breathe out... ");
            Console.Write("6");
            Thread.Sleep(1000);
            Console.Write("\b \b");
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
            Console.WriteLine();

            DateTime currentTime = DateTime.Now;
            if (currentTime >= finishedTime)
            {
                paused = false;
            }
        }
    }
}