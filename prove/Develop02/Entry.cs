public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _title;

    public Entry(string date, string promptText, string entryText,string title)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
         _title = title;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine("-----------------------"); 
    }
}