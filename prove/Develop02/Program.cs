using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> promptChoices = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        bool running = true;

        Journal journal = new Journal();

        while (running)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Choose an option from the menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Enter today's date (MM/DD/YYYY): ");
                string date = Console.ReadLine();

                Console.WriteLine("Choose a prompt from the list:");
                Console.WriteLine("1. Who was the most interesting person I interacted with today?");
                Console.WriteLine("2. What was the best part of my day?");
                Console.WriteLine("3. How did I see the hand of the Lord in my life today?");
                Console.WriteLine("4. What was the strongest emotion I felt today?");
                Console.WriteLine("5. If I had one thing I could do over today, what would it be?");
                Console.Write("Enter the number of your choice: ");
                string promptChoice = Console.ReadLine();

                Console.Write("Enter your response: ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry(date, promptChoices[int.Parse(promptChoice)], response);
                newEntry.DisplayEntry();

                Console.WriteLine("Are you satisfied with your entry? (yes/no)");
                string satisfaction = Console.ReadLine();
                if (satisfaction.ToLower() == "yes")
                {
                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry added to journal.");
                }
            }
            else if (choice == "2")
            {
                journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename to load from (make sure it ends in .txt): ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine($"Journal loaded from {filename}.");
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename to save to (make sure it ends in .txt): ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine($"Journal saved to {filename}.");
            }
            else if (choice == "5")
            {
                running = false;
                Console.WriteLine("Exiting the program.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

        }
    }
}