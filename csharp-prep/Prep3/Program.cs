using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);

        while(true)
        {

            Console.WriteLine("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());
            if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else if(guess < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it");
                break;
            }

        }
    }
}