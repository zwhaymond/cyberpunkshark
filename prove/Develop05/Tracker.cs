class Tracker
{
    private List<Goal> goalsList = new List<Goal>();
    private static int totalPoints = 0;  // Static so it's shared across all instances

    public void AddGoal(Goal goal)
    {
        goalsList.Add(goal);
        Console.WriteLine($"Goal Added: {goal.Name}");
    }

    public void LoadGoals()
    {
        Console.Write("Enter the name of the file to load goals: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            goalsList.Clear();

            if (lines.Length > 0 && lines[0].StartsWith("Total Points Earned:"))
            {
                if (!int.TryParse(lines[0].Split(':')[1].Trim(), out totalPoints))
                {
                    Console.WriteLine("Warning: Could not parse total points. Defaulting to 0.");
                    totalPoints = 0;
                }
            }

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i])) continue;

                string[] parts = lines[i].Split('|');
                if (parts.Length < 4) continue;

                string type = parts[0].Trim();
                string name = parts[1].Trim();
                string description = parts[2].Trim();
                int points = int.Parse(parts[3].Trim().Split(' ')[0]);

                bool completed = parts[3].Contains("Completed: True");

                if (type == "Simple")
                    goalsList.Add(new SimpleGoal(name, description, points, completed));
                else if (type == "Eternity")
                    goalsList.Add(new EternityGoal(name, description, points, completed));
                else if (type == "Checklist")
                {
                    int targetCompletions = int.Parse(parts[5].Trim().Split(':')[1].Trim());
                    int bonusPoints = int.Parse(parts[6].Trim().Split(':')[1].Trim());
                    goalsList.Add(new ChecklistGoal(name, description, points, targetCompletions, bonusPoints));
                }
            }

            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found. No goals loaded.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter the name of the file to save goals: ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName, false))
        {
            writer.WriteLine($"Total Points Earned: {totalPoints}\n");
            foreach (var goal in goalsList)
            {
                if (goal is SimpleGoal simpleGoal)
                    writer.WriteLine($"Simple | {simpleGoal.Name} | {simpleGoal.Description} | {simpleGoal.Points} points | Completed: {simpleGoal.Completed}");
                else if (goal is EternityGoal eternityGoal)
                    writer.WriteLine($"Eternity | {eternityGoal.Name} | {eternityGoal.Description} | {eternityGoal.Points} points | Completed: {eternityGoal.Completed}");
                else if (goal is ChecklistGoal checklistGoal)
                    writer.WriteLine($"Checklist | {checklistGoal.Name} | {checklistGoal.Description} | {checklistGoal.Points} points | Completed: {checklistGoal.Completed} | Target Completions: {checklistGoal.TargetCompletions} | Bonus Points: {checklistGoal.BonusPoints}");
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        Console.WriteLine($"Total goals loaded: {goalsList.Count}");

        if (goalsList.Count == 0)
        {
            Console.WriteLine("No goals to display.");
        }
        else
        {
            foreach (var goal in goalsList)
            {
                Console.WriteLine($"{goal.Name} - {goal.Description} ({goal.Points} points) | Completed: {goal.Completed}");
            }
        }
        Console.WriteLine($"Total Points Earned: {totalPoints}");
    }

    public void RecordGoalCompletion()
    {
        DisplayGoals();
        Console.Write("Enter the number of the goal you completed: ");
        
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= goalsList.Count)
        {
            Goal goal = goalsList[index - 1];

            if (goal is SimpleGoal simpleGoal)
            {
                simpleGoal.MarkCompleted();
                AddPoints(simpleGoal.Points);
            }
            else if (goal is EternityGoal eternityGoal)
            {
                eternityGoal.MarkCompleted();
                AddPoints(eternityGoal.Points);
            }
            else if (goal is ChecklistGoal checklistGoal)
            {
                checklistGoal.MarkCompleted();
                AddPoints(checklistGoal.Points);
            }
            else
            {
                Console.WriteLine("Unknown goal type.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid goal number.");
        }
    }

    public static void AddPoints(int points)
    {
        totalPoints += points;
    }
}
