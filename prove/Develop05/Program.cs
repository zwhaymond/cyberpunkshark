using System;

class Program
{
    static void Main(string[] args)
    {
        string choice;
        string option;
        Tracker tracker = new Tracker();

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1 - Add a Goal");
            Console.WriteLine("2 - List Goals");
            Console.WriteLine("3 - Save Goals");
            Console.WriteLine("4 - Load Goals");
            Console.WriteLine("5 - Record Event");
            Console.WriteLine("6 - Quit");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("1 - Simple Goal");
                Console.WriteLine("2 - Eternity Goal");
                Console.WriteLine("3 - Checklist Goal");
                Console.Write("What type of Goal would you like to create? ");

                do
                {
                    option = Console.ReadLine();

                    if (option == "1")
                    {
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter description: ");
                        string description = Console.ReadLine();

                        Console.Write("Enter points: ");
                        int points = int.Parse(Console.ReadLine());

                        SimpleGoal simpleGoal = new SimpleGoal(name, description, points, false);
                        tracker.AddGoal(simpleGoal);
                        break;
                    }
                    else if (option == "2")
                    {
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter description: ");
                        string description = Console.ReadLine();

                        Console.Write("Enter points: ");
                        int points = int.Parse(Console.ReadLine());

                        tracker.AddGoal(new EternityGoal(name, description, points, false));
                        break;
                    }
                    else if (option == "3")
                    {
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter description: ");
                        string description = Console.ReadLine();

                        Console.Write("Enter points per completion: ");
                        int pointsPerCompletion = int.Parse(Console.ReadLine());

                        Console.Write("Enter target completions: ");
                        int targetCompletions = int.Parse(Console.ReadLine());

                        Console.Write("Enter bonus points: ");
                        int bonusPoints = int.Parse(Console.ReadLine());

                        tracker.AddGoal(new ChecklistGoal(name, description, pointsPerCompletion, targetCompletions, bonusPoints));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You did not choose a valid option. Try again.");
                    }
                } while (true);
            }
            else if (choice == "2")
            {
                tracker.DisplayGoals();
            }
            else if (choice == "3")
            {
                tracker.SaveGoals();
            }
            else if (choice == "4")
            {
                tracker.LoadGoals();
            }
            else if (choice == "5")
            {
                tracker.RecordGoalCompletion();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Thanks for participating! Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("You did not choose a valid option. Try again.");
            }
        }
    }
}
