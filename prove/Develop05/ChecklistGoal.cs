public class ChecklistGoal : Goal
{
    public int TargetCompletions { get; set; }
    public int BonusPoints { get; set; }
    public int CurrentCompletions { get; private set; }

    // Constructor
    public ChecklistGoal(string name, string description, int points, int targetCompletions, int bonusPoints)
        : base(name, description, points, false)
    {
        TargetCompletions = targetCompletions;
        BonusPoints = bonusPoints;
        CurrentCompletions = 0;
    }

    // Displays goal with checkbox and current progress
    public override void DisplayGoalWithCheckbox()
    {
        string status = CurrentCompletions >= TargetCompletions ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name} - {Description} ({Points} points each time) | Completed: {CurrentCompletions}/{TargetCompletions} | Bonus Points: {BonusPoints} (Earned when fully completed!)");
    }

    // Marks goal as completed and tracks completions
    public override void MarkCompleted()
    {
        if (CurrentCompletions < TargetCompletions)
        {
            // Increment the current completions count
            CurrentCompletions++;
            Console.WriteLine($"Goal '{Name}' completed {CurrentCompletions}/{TargetCompletions} times.");
        }

        // Check if we have reached the target completions
        if (CurrentCompletions >= TargetCompletions)
        {
            // Award bonus points when goal is fully completed
            Completed = true;
            Console.WriteLine($"Goal '{Name}' fully completed! You earned {BonusPoints} bonus points!");

            // Add bonus points to the total score
            Tracker.AddPoints(BonusPoints);  // Call Tracker to add bonus points
        }
    }
}
