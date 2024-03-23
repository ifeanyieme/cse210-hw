class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Mindfulness Activities Menu:");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.WriteLine("-------------------------------");
            Console.Write("\nEnter your choice (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            MindfulnessActivity activity;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                case 4:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    continue;
            }

            // Start the selected activity
            activity.StartActivity();
        }
    }
}
