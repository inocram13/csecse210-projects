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
    public ReflectingActivity() 
    : base ("Reflecting", "This activity will help you reflect on times when you have shown strength and resilience.", 50 )
    {
       
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
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
    public string GetRandomQuestion()
    { 
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
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
