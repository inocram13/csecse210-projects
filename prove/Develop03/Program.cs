using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a library of scriptures
        var scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways acknowledge Him, and He will make your paths straight."),
            new Scripture(new Reference("Philippians", 4, 6, 7),
                "Do not be anxious about anything, but in every situation, by prayer and petition, with thanksgiving, present your requests to God."),
            new Scripture(new Reference("Romans", 8, 28),
                "And we know that in all things God works for the good of those who love him, who have been called according to his purpose."),
            new Scripture(new Reference("Jeremiah", 29, 11),
                "For I know the plans I have for you, declares the Lord, plans to prosper you and not to harm you, plans to give you hope and a future."),
            new Scripture(new Reference("Psalm", 23, 1),
                "The Lord is my shepherd; I shall not want.")
        };

         Random random = new Random();
        Scripture currentScripture = null;

        while (true)
        {
            // If currentScripture is null or completely hidden, select a new scripture
            if (currentScripture == null || currentScripture.IsCompletelyHidden())
            {
                currentScripture = scriptures[random.Next(scriptures.Count)];
                Console.Clear();
                Console.WriteLine(currentScripture.GetDisplayText());
                Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            }
            string input = Console.ReadLine();
            if(input?.ToLower() == "quit") break;
            currentScripture.HideRandomWords(3);
            if(currentScripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("Jaboooom");
                break; 
            }else
            {
                Console.Clear();
                Console.WriteLine(currentScripture.GetDisplayText()); // Display the updated scripture
                Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            }
        }
        
    }
}