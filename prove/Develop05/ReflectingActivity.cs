using System;
using System.Collections.Generic;
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need",
        "Think of a time when you did something truly selfless"
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private List<string> _unusedPrompts;
    private List<string> _unusedQuestions;
    private Random _random;
    public ReflectingActivity() 
    : base ("Reflecting", "This activity will help you reflect on times when you have shown strength and resilience.", 50 )
    {
        _random = new Random();
        ResetUnusedPrompts();
        ResetUnusedQuestions();
    }
    public void ResetUnusedPrompts()
    {
         _unusedPrompts = new List<string>(_prompts);
        Shuffle(_unusedPrompts);
    }
    private void ResetUnusedQuestions()
    {
        _unusedQuestions = new List<string>(_questions);
        Shuffle(_unusedQuestions); 
    }
    private void Shuffle<T>(List<T> list)
    {
         Random rng = new Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestion();
        DisplayEndMessage();
    }
    public string GetRandomPrompt()
    {
       if (_unusedPrompts.Count == 0)
        {
            ResetUnusedPrompts();  // Reshuffle and reset when all are used
        }

        string prompt = _unusedPrompts[0];
        _unusedPrompts.RemoveAt(0);  // Remove the used prompt
        return prompt;
    }
    public string GetRandomQuestion()
    { 
        if (_unusedQuestions.Count == 0)
        {
            ResetUnusedQuestions();  // Reshuffle and reset when all are used
        }

        string question = _unusedQuestions[0];
        _unusedQuestions.RemoveAt(0);  // Remove the used question
        return question;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: ");
        string prompt = GetRandomPrompt(); 
        Console.WriteLine(prompt);
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }
    public void DisplayQuestion()
    {   
        Console.WriteLine("Now ponder each of the following questions as they are related to this experience.");
        Console.WriteLine("You may begin in:");

        ShowCountDown(10);

         DateTime startTime = DateTime.Now;

    // Loop through the questions until the time expires or no more questions are available
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
        // Get a random question
         string question = GetRandomQuestion();
        
        // Check if there are no more questions left
        if (string.IsNullOrEmpty(question))
        {
            Console.WriteLine("No more questions available.");
            break;  // Exit the loop if there are no questions
        }

        Console.WriteLine(question);

        ShowSpinner(10);
        }  
    }
}  
