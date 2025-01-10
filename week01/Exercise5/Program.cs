using System;
using System.Net.Security;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string userName = PromptName();
        int userNumber = PromptNumber();

        int squaredNumber = SquareNumber(userNumber);
        Message(userName, squaredNumber);

    }

    static void DisplayMessage()
    {
        Console.WriteLine("Hello! Welcome to the program.");
    }

    static string PromptName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptNumber()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }

    static void Message (string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}.");
    }
}