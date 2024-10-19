using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("   1. Start Breathing Activity");
            Console.WriteLine("   2. Start Reflecting Activity");
            Console.WriteLine("   3. Start Listing Activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select Choice from the MENU: ");
        
        

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity  breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if(choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if(choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if(choice == "4")
            {
                Console.WriteLine("Thank You!!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid Choice, Try Again");
            }
        }

    }

}
// Make sure no random prompts/questions are selected until they have all been used at least once in that session.