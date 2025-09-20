using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("List adder. Enter numbers to add to the list. Type 0 to finish:");

        List<int> numbers = new List<int>();
        int input;

        do
        {
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");
        int average = (int)numbers.Average();
        Console.WriteLine($"The average is: {average}");
        int largest = numbers.Max();
        Console.WriteLine($"The largest number is: {largest}");
        int smallestPositive = 0;
        foreach (int number in numbers)
        {
            if (number > 0 && (smallestPositive == 0 || number < smallestPositive))
            {
                smallestPositive = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");  
        List<int> sortedNumbers = new List<int>(numbers);
        sortedNumbers.Sort();
        Console.WriteLine("The sorted numbers are:");
        foreach (int number in sortedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}