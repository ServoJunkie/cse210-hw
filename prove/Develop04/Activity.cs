using System.Security.Authentication.ExtendedProtection;

public class Activity
{
    private string _start = "Excellent choice!";
    private string _finish = "Well done!!";
    private int _time = 0;
    private string _typeOfActivity = "Activity does not have a type value.";
    private string _activityDescription = "No relevant description available.";

    protected bool paused = true;

    public string GetStartingMessage()
    {
        return _start;
    }

    public string GetEndingMessage()
    {
        return _finish;
    }

    public int GetTime()
    {
        return _time;
    }

    public void SetTime(int inputTime)
    {
        _time = inputTime;
    }

    public string GetTypeOfActivity()
    {
        return _typeOfActivity;
    }

    public void SetTypeOfActivity(string typeOfActivity)
    {
        _typeOfActivity = typeOfActivity;
    }

    public string GetActivityDescription()
    {
        return _activityDescription;
    }

    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }

    public void DisplayIntro()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_typeOfActivity} Activity.");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
        Console.Write("How long would you like for your session? ");
    }
}