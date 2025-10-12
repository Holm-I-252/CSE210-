using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Breathing breathingActivity = new Breathing();
                breathingActivity.StartBreathingActivity();
            }
            else if (choice == "2")
            {
                Reflection reflectionActivity = new Reflection();
                reflectionActivity.StartReflectionActivity();
            }
            else if (choice == "3")
            {
                Listing listingActivity = new Listing();
                listingActivity.StartListingActivity();
            }
            else if (choice == "4")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}