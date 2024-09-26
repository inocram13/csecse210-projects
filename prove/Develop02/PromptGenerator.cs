public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>()
        {
            "What is something you're grateful for today?",
            "What’s a new skill you'd like to learn?",
            "Describe your favorite place in nature.",
            "What was the best part of your day?",
            "What inspires you right now?",
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}