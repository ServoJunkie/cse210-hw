public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _totalToComplete;
    private int _bonus;

    public ChecklistGoal(string Name, string Description, int Points, int TotalToComplete, int Bonus) : base(Name, Description, Points)
    {
        _totalToComplete = TotalToComplete;
        _bonus = Bonus;
    }

    public override bool IsCompleted()
    {
        if (_amountCompleted == _totalToComplete)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void SetCompleted()
    {
        _amountCompleted ++;
    }

    public int GetGoalPoints()
    {
        return _amountCompleted;
    }
    
    public override string GetGoalType()
    {
        return "Checklist";
    }

    public override void Display()
    {
        string _name = GetName();
        string _description = GetDescription();
        string _checked = " ";

        if (_amountCompleted == _totalToComplete)
        {
            _checked = "X";
        }
        Console.WriteLine($"[{_checked}] {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_totalToComplete}");;
    }

    public override string Serialize()
    {
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        string _serializedString = $"Checklist,{name},{description},{points},{_totalToComplete}, {_bonus}";
        return _serializedString;
    }
}