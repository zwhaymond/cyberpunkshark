using System;

class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool completed = false)
        : base(name, description, points, completed) { }

    public override void DisplayGoalWithCheckbox()
    {
        string status = Completed ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name} - {Description} ({Points} points)");
    }

    public override void MarkCompleted()
    {
        Completed = true;
    }
}




