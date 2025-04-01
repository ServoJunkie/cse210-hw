using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        string assignment1Summary = assignment1.GetSummary();
        Console.WriteLine(assignment1Summary);

        Console.WriteLine();

        MathAssignment mathAssignment2 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        string mathAssignment2Summary = mathAssignment2.GetSummary();
        Console.WriteLine(mathAssignment2Summary);
        string mathAssignment2HomeworkList = mathAssignment2.GetHomeworkList();
        Console.WriteLine(mathAssignment2HomeworkList);

        Console.WriteLine();

        WritingAssignment writingAssignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string writingAssignment3Summary = writingAssignment3.GetSummary();
        Console.WriteLine(writingAssignment3Summary);
        string writingAssignment3WritingInformation = writingAssignment3.GetWritingInformation();
        Console.WriteLine(writingAssignment3WritingInformation);
    }
}