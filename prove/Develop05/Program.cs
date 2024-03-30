// Program.cs

using System;

class Program
{
    static void Main()
    {
        User user = new User();

        while (true)
        {
            Console.WriteLine("\n=== Eternal Quest Menu ===");
            Console.WriteLine("1. Add Simple Goal");
            Console.WriteLine("2. Add Eternal Goal");
            Console.WriteLine("3. Add Checklist Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Display Goals");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice (1-6): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the name of the Simple Goal: ");
                    string simpleGoalName = Console.ReadLine();
                    user.AddGoal(new SimpleGoal(simpleGoalName, 1000));
                    break;

                case "2":
                    Console.Write("Enter the name of the Eternal Goal: ");
                    string eternalGoalName = Console.ReadLine();
                    user.AddGoal(new EternalGoal(eternalGoalName, 100));
                    break;

                case "3":
                    Console.Write("Enter the name of the Checklist Goal: ");
                    string checklistGoalName = Console.ReadLine();
                    Console.Write("Enter the target count for the Checklist Goal: ");
                    int targetCount = int.Parse(Console.ReadLine());
                    user.AddGoal(new ChecklistGoal(checklistGoalName, 50, targetCount));
                    break;

                case "4":
                    Console.WriteLine("\n=== Record Event Menu ===");
                    Console.WriteLine("Select a goal to record an event:");
                    for (int i = 0; i < user.Goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {user.Goals[i].name}");
                    }

                    Console.Write("Enter the goal number: ");
                    int goalNumber = int.Parse(Console.ReadLine()) - 1;

                    if (goalNumber >= 0 && goalNumber < user.Goals.Count)
                    {
                        user.RecordEvent(user.Goals[goalNumber]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal number.");
                    }
                    break;

                case "5":
                    user.DisplayGoals();
                    break;

                case "6":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                    break;
            }
        }
    }
}