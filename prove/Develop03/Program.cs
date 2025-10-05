using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        Reference reference1 = new Reference("John", 3, 16);

        Scripture scripture1 = new Scripture(reference1, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        Scripture scripture2 = new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");
        Scripture scripture3 = new Scripture(new Reference("Philippians", 4, 13), "I can do all this through him who gives me strength.");
        Scripture scripture4 = new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might have joy.");
        Scripture scripture5 = new Scripture(new Reference("Ether", 12, 27), "And if men come unto me I will show unto them their weakness.");
        Scripture scripture6 = new Scripture(new Reference("Mosiah", 2, 17), "When ye are in the service of your fellow beings ye are only in the service of your God.");

        List<Scripture> scriptures = new List<Scripture>
        {
            scripture1, scripture2, scripture3, scripture4, scripture5, scripture6
        };

        Random rand = new Random();
        Scripture pickedScripture = scriptures[rand.Next(scriptures.Count)];


        while (running)
        {
            Console.Clear();
            Console.WriteLine(pickedScripture.GetScripture());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "quit")
            {
                running = false;
            }
            else
            {
                pickedScripture.HideWords();
            }
        }
    }
}