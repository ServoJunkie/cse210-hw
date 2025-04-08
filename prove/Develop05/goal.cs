using System.Runtime.Serialization;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal()
    {

    }
    
    public Goal(string Name, string Description, int Points)
    {
        _name = Name;
        _description = Description;
        _points = Points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public abstract string GetType();
    public abstract void Display();
    public abstract bool IsCompleted();
    public abstract void SetCompleted();
    public abstract string Serialize();
    public virtual int GetGoalPoint()
    {
        return _points;
    }
}