public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
      "Who are people that you appreciate?",
      "What are personal strengths of yours?",
      "Who are people that you have helped this week?",
      "When have you felt the Holy Ghost this month?",
      "Who are some of your personal heroes?"
    };
    public ListingActivity()
    :base("Listing", "This activity will help you list as many responses as you can to the given prompt", 60)
    {
       
    }
    public void Run()
    {
      DisplayStartingMessage();
      GetRandomPrompt();
      ShowCountDown(10);
      GetListFromUser();
    }
      public string GetRandomPrompt()
    {
        Console.WriteLine("List as many responses you can to the following prompt");  
        Random random = new Random();
        Console.WriteLine("You may begin in: ");
        return _prompts[random.Next(_prompts.Count)];


    }
    public List<string> GetListFromUser()
    {
        List<string> userResponses = new List<string>();
        Console.WriteLine("Start listing your responses. Type 'done' when finished:");
        while(true)
        {
          Console.Write("> ");
        string input = Console.ReadLine();
        if(input?.ToLower() == "done")
        {
          break;
        }
        userResponses.Add(input);
        }
        return userResponses;
    }
}