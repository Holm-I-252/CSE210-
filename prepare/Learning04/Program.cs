using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math_1 = new MathAssignment("Jimmy", "Fractions", "5.1", "1-10");
        Console.WriteLine(math_1.GetSummary());
        Console.WriteLine(math_1.GetHomeworkList());

        WritingAssignment writing_1 = new WritingAssignment("Jimmy 2", "European History", "The Causes of World War II");
        Console.WriteLine(writing_1.GetSummary());
        Console.WriteLine(writing_1.GetWritingInformation());
    }
}