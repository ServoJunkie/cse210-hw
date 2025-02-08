public class Entry
{
    public string _date;
    public string _prompt;
    public string _text;

    public string _username;

    public void Display()
    {
        Console.WriteLine($"User: {_username} - Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_text}");
        Console.WriteLine("");
    }

    public string Serialize()
    {
        return ($"{_username}~{_date}~{_prompt}~{_text}");
    }
}