public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    public ListingActivity()
    :base("Listing", "This activity will help you list as many responses as you can to the given prompt", 60)
    {
       
    }
    public void Run()
    {

    }
      public void GetRandomPrompt()
    {

    }
    public List<string> GetListFromUser()
    {
        List<string> userResponses = new List<string>();
        Console.WriteLine("Start listing your responses. Type 'done' when finished:");

        return userResponses;
    }
}