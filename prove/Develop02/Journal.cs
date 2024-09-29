using System;

public class Journal
{    // Attributes, a list to hold the journal entries.
    public List<Entry> _entries = new List<Entry>();

     // Method to add a new journal entry.
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
      // Method to display all entries in the journal.
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }

    }
     // Method to dat the journal to a file
    public void SaveToFile(string file)
    {
        List<string> lines = new List<string>();
        foreach (var entry in _entries)
        {
            lines.Add($"{entry._date}|{entry.promptText}|{entry.entryText}");

        }
        file.WriteAllLines(file, lines);
    }
      
      // Method to load lines from a file
    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(file);
        foreach (var line in lines)
        {
            var parts = line.Split('|');
            if (parts.Length == 3)
            {
                _entries.Add(new Entry(parts[0], parts[1], parts[2]));
            }
        }
    }
}