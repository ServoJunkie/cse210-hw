public class Verse
{
    private List<Word> _words = new List<Word>();

    private int AmountOfWords;
    
    public void DisplayVerse()
    {
        foreach (Word currentWord in _words)
        {
            currentWord.Display();
            Console.Write(" ");
        }
    }
   
    public bool HideWords()
    {
        AmountOfWords = _words.Count() + 1;

        Random randomGenerator = new Random();
        int currentWordNumber = randomGenerator.Next(1, AmountOfWords);

        return false;
    }
}