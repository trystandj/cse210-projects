using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment assignment = new Assignment("John Smith", "Fractions");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("John Smith", "Fractions", "Section 1.1", "Problems 1-10");
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("John Smith", "American Revolution", "The Causes of the American Revolution");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}