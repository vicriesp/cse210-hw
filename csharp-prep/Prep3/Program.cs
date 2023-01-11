using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int count = 0;
        int guess = -1;
        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            count = count +1;

            if (guess > number)
            
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higer");
            }
            else
            {
                Console.WriteLine("You Guessed it");
                Console.WriteLine($"It took you {count} guesses");
            }
        }
    }
}