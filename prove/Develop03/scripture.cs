using System.Text.RegularExpressions;

public class Scripture
{
    private List<Verse> _verses = new List<Verse>();

    private string _reference;


    public Scripture()
    {
        string scripture = "No scripture entered";

        string[] verses = Regex.Split(scripture, "\\d+ ");
        foreach (string verse in verses)
        {
            Verse newVerse = new Verse(verse);
            _verses.Add(newVerse);
        }
    }

    public Scripture(string reference, string text)
    {
        _reference = reference;

        string[] verses = Regex.Split(text, "\\d+ ");
        foreach (string verse in verses)
        {
            Verse newVerse = new Verse(verse);
            _verses.Add(newVerse);
        }
    }


    public void DisplayScripture()
    {
        Console.Write($"{_reference} ");

        foreach (Verse currentVerse in _verses)
        {
            currentVerse.DisplayVerse();
        }
        Console.WriteLine();
    }

    public bool IsHidden()
    {
        foreach (Verse currentVerse in _verses)
        {
            bool hidden = currentVerse.IsHidden();
            if (!hidden)
            {
                return false;
            }
        }

        return true;
    }

    public bool HideWord()
    {
        if (IsHidden())
        {
            return false;
        }
        
        int amountOfWordsToHide = 3;
        int _AmountOfVerses = _verses.Count();
        Random randomGenerator = new Random();
        
        do
        {
            int currentVerseNumber = randomGenerator.Next(0, _AmountOfVerses);
            Verse currentVerse = _verses[currentVerseNumber];
            bool hidden = currentVerse.IsHidden();

            if (hidden == false)
            {
                if (currentVerse.HideWord())
                {
                    amountOfWordsToHide --;
                    if (IsHidden())
                    {
                        amountOfWordsToHide = 0;
                    }
                }
            }
        } while (amountOfWordsToHide != 0);

        return true;
    }
}