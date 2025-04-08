public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string Name, string Description, int Points) : base(Name, Description, Points)
    {
        
    }

    public override bool IsCompleted()
    {
        return _completed;
    }

    public override void SetCompleted()
    {
        _completed = true;
    }

    public override string GetType()
    {
        return "Simple";
    }

    public override void Display()
    {
        string _name = GetName();
        string _description = GetDescription();
        string _checked = " ";

        if (_completed == true)
        {
            _checked = "X";
        }
        Console.WriteLine($"[{_checked}] {_name} ({_description})");
    }

    public override string Serialize()
    {
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        string _serializedString = $"Simple,{name},{description},{points}";
        return _serializedString;
    }
}