using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        bool _running = true;
        int _totalPoints = 0;

        while (_running)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Activity");
            Console.WriteLine("2. List Activities");
            Console.WriteLine("3. Complete Activity");
            Console.WriteLine("4. Show Total Points");
            Console.WriteLine("5. Save Goals to File");
            Console.WriteLine("6. Load Goals from File");
            Console.WriteLine("7. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Select Activity Type:");
                Console.WriteLine("1. Simple Activity");
                Console.WriteLine("2. Eternal Activity");
                Console.WriteLine("3. Checklist Activity");
                Console.Write("Enter choice: ");
                string activityType = Console.ReadLine();

                Console.Write("Enter activity name: ");
                string name = Console.ReadLine();
                Console.Write("Enter point value: ");
                int pointValue = int.Parse(Console.ReadLine());

                if (activityType == "1")
                {
                    activities.Add(new Simple(name, pointValue));
                }
                else if (activityType == "2")
                {
                    activities.Add(new Eternal(name, pointValue));
                }
                else if (activityType == "3")
                {
                    Console.Write("Enter number of times completable: ");
                    int timesCompleteable = int.Parse(Console.ReadLine());
                    Console.Write("Enter incremental points: ");
                    int incrementalPoints = int.Parse(Console.ReadLine());
                    activities.Add(new Checklist(name, pointValue, timesCompleteable, incrementalPoints));
                }
            }

            else if (choice == "2")
            {
                Console.WriteLine("Activities:");
                foreach (var activity in activities)
                {
                    Console.WriteLine(activity.IsCompleted());
                }
            }

            else if (choice == "3")
            {
                Console.WriteLine("Select an activity to complete:");
                for (int i = 0; i < activities.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {activities[i].GetName()}");
                }
                int activityIndex = int.Parse(Console.ReadLine()) - 1;
                if (activityIndex >= 0 && activityIndex < activities.Count)
                {
                    int pointsEarned = activities[activityIndex].Complete();
                    _totalPoints += pointsEarned;
                    Console.WriteLine($"Total Points: {_totalPoints}");
                }
                else
                {
                    Console.WriteLine("Invalid selection.");
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine($"Total Points: {_totalPoints}");
            }
            else if (choice == "5")
            {
                Console.Write("Enter filename to save goals: ");
                string filename = Console.ReadLine();
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.WriteLine(_totalPoints);
                    foreach (var activity in activities)
                    {
                        writer.WriteLine(activity.SaveData());
                    }
                }
                Console.WriteLine("Goals saved.");
            }
            else if (choice == "6")
            {
                Console.Write("Enter filename to load goals: ");
                string filename = Console.ReadLine();
                if (File.Exists(filename))
                {
                    activities.Clear();
                    using (StreamReader reader = new StreamReader(filename))
                    {
                        _totalPoints = int.Parse(reader.ReadLine());
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            var parts = line.Split('|');
                            string type = parts[0];
                            string name = parts[1];
                            int pointValue = int.Parse(parts[2]);

                            if (type == "Simple")
                            {
                                activities.Add(new Simple(name, pointValue));
                            }
                            else if (type == "Eternal")
                            {
                                activities.Add(new Eternal(name, pointValue));
                            }
                            else if (type == "Checklist")
                            {
                                int timesCompleteable = int.Parse(parts[3]);
                                int timesCompleted = int.Parse(parts[4]);
                                int incrementalPoints = int.Parse(parts[5]);
                                activities.Add(new Checklist(name, pointValue, timesCompleteable, incrementalPoints));
                                for (int i = 0; i < timesCompleted; i++)
                                {
                                    activities[activities.Count - 1].Complete();
                                }
                                Console.Clear();
                            }
                        }
                    }
                    Console.WriteLine("Goals loaded.");
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }

            else if (choice == "7")
            {
                _running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}