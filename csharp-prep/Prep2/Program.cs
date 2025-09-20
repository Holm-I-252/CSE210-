using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Grade Converter. Enter your grade (0-100):");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);
        string letter = "";
        string sign = "";

        if (gradeInt >= 90)
        {
            letter = "A";
        }
        else if (gradeInt >= 80)
        {
            letter = "B";
        }
        else if (gradeInt >= 70)
        {
            letter = "C";
        }
        else if (gradeInt >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter != "F")
        {
            int lastDigit = gradeInt % 10;
            if (lastDigit >= 7 && letter != "A")
            {
                sign = "+";
            }
            else if (lastDigit <= 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"Your letter grade is: {letter}{sign}");
    }
}