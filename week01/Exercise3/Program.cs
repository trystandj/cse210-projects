using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int count = 0;
        int numberGuess = -1;
        while (numberGuess != number)
        {
            Console.Write("What is your guess? ");
            numberGuess = int.Parse(Console.ReadLine());
            count += 1;
            
            if (numberGuess > number)
            {
                Console.WriteLine("Your guess is too high.");
            }
            else if (numberGuess < number)
            {
                Console.WriteLine("Your guess is too low."); 
            }
            else
            {
                Console.WriteLine("You guessed the magic number!");
            }
        }
        Console.WriteLine($"You guessed the magic number in {count} tries.");
    }
}