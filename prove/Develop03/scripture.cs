public class Scripture
{
    private List<Verse> _verses = new List<Verse>();

    public void DisplayScripture()
    {
         foreach (Verse currentVerse in _verses)
        {
            currentVerse.DisplayVerse();
        }
    }
}