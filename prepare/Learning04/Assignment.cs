public class Assignment
{
    protected string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        string assembledSummary = ($"{_studentName} - {_topic}");
        return assembledSummary;
    }
}