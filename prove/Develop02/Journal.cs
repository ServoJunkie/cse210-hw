using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public bool _changed;

    public void Load(string fileName)
    {
        _entries.Clear();
        
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            string newUsername = parts[0];
            string newDate = parts[1];
            string newPrompt = parts[2];
            string newText = parts[3];

            Entry newEntry = new Entry();
            newEntry._username = newUsername;
            newEntry._date = newDate;
            newEntry._prompt = newPrompt;
            newEntry._text = newText;

            _entries.Add(newEntry);
        }
    }

    public void Save(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry fullEntry in _entries)
            {
                outputFile.WriteLine(fullEntry.Serialize());
            }
        }
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        foreach (Entry activeEntry in _entries)
        {
            activeEntry.Display();
        }
    }
}