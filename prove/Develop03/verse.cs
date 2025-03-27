public class Verse
{
    private List<Word> _words = new List<Word>();

    public Verse()
    {
        string text = "No scripture verse entered.";

        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public Verse(string text)
    {
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

   
    public void DisplayVerse()
    {
        foreach (Word currentWord in _words)
        {
            currentWord.Display();
            Console.Write(" ");
        }
    }

    public bool IsHidden()
    {
        foreach (Word currentWord in _words)
        {
            bool hidden = currentWord.IsHidden();
            if (!hidden)
            {
                return false;
            }
        }
        
        return true;
    }

    public bool HideWord()
    {
        int _AmountOfWords = _words.Count();

        Random randomGenerator = new Random();
        int currentWordNumber = randomGenerator.Next(0, _AmountOfWords);
        Word currentWord = _words[currentWordNumber];
        bool hidden = currentWord.IsHidden();

        if (hidden == false)
        {
            currentWord.HideWord();
            return true;
        }

        return false;
    }
}