// Welcome to Journal Project
// Please select one of the following choices.
// 1. Write
// 2.Display
// 3. Load
// 4.Save
// 5. Quit
// What would you like to do? 
using System.Collections.Generic;
using System.Runtime.CompilerServices;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry) 
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SavetoFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._title}|{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 4)
                    {
                        Entry entry = new Entry(parts[0], parts[1], parts[2], parts[3]);
                        _entries.Add(entry);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
    
}
