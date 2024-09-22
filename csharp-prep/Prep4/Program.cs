using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
         List<int> numbers = new List<int>();

        while(true)
        {
            Console.WriteLine("Enter number(0 to stop): ");
            int number = int.Parse(Console.ReadLine());
           
            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
        }
        int sum = 0;
        foreach(int num in numbers)
        {
            sum += num;
        }
        if (numbers.Count > 0)
        {
            double average = (double)sum / numbers.Count;

            int largest = numbers.Max();
            Console.WriteLine("The sum is: " +sum);
            Console.WriteLine("The Average is: " + average);
            Console.WriteLine("The Largest number is " + largest);
        }
    }
}