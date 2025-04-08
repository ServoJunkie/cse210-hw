public class EternalGoal : Goal
{
    public EternalGoal(string Name, string Description, int Points) : base(Name, Description, Points)
    {

    }

    public override bool IsCompleted()
    {
        return false;
    }

    public override void SetCompleted()
    {
        Console.WriteLine("Error. Cannot set eternal goal to complete.");
    }

    public override string GetGoalType()
    {
        return "Eternal";
    }

    public override void Display()
    {
        string _name = GetName();
        string _description = GetDescription();
        string _checked = " ";

        Console.WriteLine($"[{_checked}] {_name} ({_description})");
    }

    public override string Serialize()
    {
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        string _serializedString = $"Eternal,{name},{description},{points}";
        return _serializedString;
    }
}