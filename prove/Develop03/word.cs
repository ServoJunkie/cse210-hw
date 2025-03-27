public class Word
{
    private string _word;

    private bool _hidden = false;


    public Word()
    {
        _word = "error";
    }
    
    public Word(string text)
    {
        _word = text;
    }
    
    
    public void Display()
    {
        if (!_hidden)
        {
            Console.Write($"{_word}");
        }
        else
        {
            Console.Write("_____");
        }
    }

    public bool HideWord()
    {
        _hidden = true;
        return false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }
}