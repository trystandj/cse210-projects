using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);
        int lastNumber = gradeNumber % 10;

        string letterGrade = "";
        string sign = "";

        if (gradeNumber >= 60 && gradeNumber <= 95)
        {
            if (lastNumber >= 5)
            {
                sign = "+";
            }
            else if (lastNumber < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        if (gradeNumber >= 90)
        {
            letterGrade = "A";
        }
        else if (gradeNumber >= 80)
        {
            letterGrade = "B";
        }
        else if (gradeNumber >= 70)
        {
            letterGrade = "C";
        }
        else if (gradeNumber >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your letter grade is: {letterGrade}{sign}.");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congrats! You passed!");
        }
        else
        {
            Console.WriteLine("Try studing more next time!");
        }
    }
}