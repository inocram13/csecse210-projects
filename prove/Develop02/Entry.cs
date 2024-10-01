public class Entry
{
    public string _title;
    public string _date;
    public string _promptText;
    public string _entryText;
    

    public Entry(string title, string date, string promptText, string entryText)
    {
        _title = title;
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
         
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