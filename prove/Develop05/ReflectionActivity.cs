using System;
using System.Collections.Generic;
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    public ReflectingActivity() : base ("Reflecting", "This activity will help you reflect on times when you have shown strength and resilience.", 50 )
    {
       
    }
    public void Run()
    {

    }
    public string GetRandomPrompt()
    {
         return "";
    }
    public string GetRandomQuestion()
    {
        return "";
    }
    public void DisplayPrompt()
    {
        
    }
    public void DisplayQuestion()
    {

    }
}  
