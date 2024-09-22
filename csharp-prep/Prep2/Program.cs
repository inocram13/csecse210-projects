using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int gradepercentage = int.Parse(Console.ReadLine());
        if (gradepercentage >= 90)
        {
            Console.WriteLine("A");
        }
        else if (gradepercentage >= 80)
        {
            Console.WriteLine("B");
        }
        else if(gradepercentage >= 70)
        {
            Console.WriteLine("C");
        }
        else if(gradepercentage >= 60)
        {
            Console.WriteLine("D");
        }
        else if(gradepercentage > 60)
        {
            Console.WriteLine("F");
        }
        if (gradepercentage >= 70)
        {
            Console.WriteLine( "Congrats You Passed");
        }
        else
        {
            Console.WriteLine("Sorry You Failed");
        }
    }
}