using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int inputtedNumbers = -1;
        int count = -1;

        while (inputtedNumbers != 0)
        {
            System.Console.Write("Enter a number (0 to quit): ");
            inputtedNumbers = int.Parse(System.Console.ReadLine());
            numbers.Add(inputtedNumbers);
            count += 1;
        }

        int sum = 0;
        int largest = 0;

        foreach (int number in numbers)
        {
            sum += number;

            if (number > largest)
            {
                largest = number;
            }
        }

        int average = sum / count;
        
        Console.WriteLine($"The sum is: {sum}.");
        Console.WriteLine($"The average is: {average}.");
        Console.WriteLine($"The largest number is: {largest}.");
    }
}