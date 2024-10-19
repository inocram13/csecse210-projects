using System;
using System.Threading;
public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration ;
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting Activity: {_name}");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like your session? : ");
        _duration = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Get ready");
        ShowSpinner(3);
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine("Husay Mo!!!");
        Console.WriteLine($"You have completed another {_duration} seconds of {_name}");
    }
    public void ShowSpinner(int seconds)
    {
        {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b\b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b\b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b\b");

        }
        Console.WriteLine();
    }
    }
    public void ShowCountDown(int second)
    {
         for (int i = second; i > 0; i--)
        {
            Console.Write($"\r{i} seconds remaining...");
            System.Threading.Thread.Sleep(1000);  // Pausing for 1 second between each number
  
        }
        Console.WriteLine();
    }
}