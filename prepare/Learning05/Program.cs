using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Benett", "Multiplication");
        
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();
        MathAssignment assignment2 = new MathAssignment("7.3", "8-19","Roberto Rodrriguez", "Fraction");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine();
        WritingAssignment assignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II" );
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
        
    }
}