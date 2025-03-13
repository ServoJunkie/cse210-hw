public class Word
{
    private string _word = "error";

    private bool _hidden = false;

    public void Display()
    {
        if (_hidden == false)
        {
            Console.Write($"{_word}");
        }
        else
        {
            Console.Write("_____");
        }
    }

    public void HideWord()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public void StoreWord(string newWord)
    {
        _word = newWord;
    }
}