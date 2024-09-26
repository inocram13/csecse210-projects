using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {   
        Journal theJournal = new Journal();
        
        while(true)
        {
            Console.WriteLine("Welcome to Journal Project!");
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5. Quit");

            Console.Write("Your Choice: ");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1": // Write

                PromptGenerator promptGenerator = new PromptGenerator();

                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Enter your response: ");
                    string response = Console.ReadLine();
                    Console.Write("Enter a title for your entry: ");
                    string title = Console.ReadLine();

                    Entry newEntry = new Entry(DateTime.Now.ToString("yyyy-MM-dd"), prompt, response,title);
                    theJournal.AddEntry(newEntry);
                    Console.WriteLine("Your entry has been saved!");
                    break;

                case "2": // Display
                    theJournal.DisplayAll();
                    break;case "3": // Load
                    Console.Write("Enter the filename to load from: ");
                    string loadFile = Console.ReadLine();
                    theJournal.LoadFromFile(loadFile);
                    Console.WriteLine("Entries loaded!");
                    break;

                case "4": // Save
                    Console.Write("Enter the filename to save to: ");
                    string saveFile = Console.ReadLine();
                    theJournal.SavetoFile(saveFile);
                    Console.WriteLine("Entries saved!");
                    break;
                
                 case "5": // Quit
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;                
            } 
        }    
    }
}