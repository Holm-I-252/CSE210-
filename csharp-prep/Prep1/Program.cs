using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("James Bond name generator. Enter your first name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter your last name:");
        string lastName = Console.ReadLine();

        string bondName = $"{lastName}, {firstName} {lastName}";
        Console.WriteLine($"Your name is: {bondName}");
    }
}
