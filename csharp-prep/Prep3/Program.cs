using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            int targetNumber = new Random().Next(1, 101);
            int guesses = 0;
            int guess = 0;

            while (guess != targetNumber)
            {
                Console.WriteLine("Number guessing game. Guess a number between 1 and 100:");
                guesses++;
                string input = Console.ReadLine();
                guess = int.Parse(input);
                if (guess >= 1 && guess <= 100)
                {
                    if (guess < targetNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > targetNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it! It took you " + guesses + " guesses.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
            Console.WriteLine("Do you want to play again? (y/n)");
            string playAgain = Console.ReadLine().ToLower();
            if (playAgain == "n")
            {
                running = false;
                Console.WriteLine("Thanks for playing!");
            }
        }
    }
}
        