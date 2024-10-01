using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
       Fraction fraction1 = new Fraction();
       Fraction fraction2 = new Fraction(6);
       Fraction fraction3 = new Fraction(3,4);
       Fraction fraction4 = new Fraction(1,3);

    //    Display
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());
        // Setters
        fraction3.SetTop(7);
        fraction3.SetBottom(13);
        // Getters
        Console.WriteLine(fraction3.GetTop());
        Console.WriteLine(fraction3.GetBottom());
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
    }

}   