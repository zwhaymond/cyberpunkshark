using System;

class EternityGoal : Goal
{
    public EternityGoal(string name, string description, int points, bool completed)
        : base(name, description, points, completed) { }

    public override void DisplayGoalWithCheckbox()
    {
        string status = Completed ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name} - {Description} ({Points} points) | Completed: {Completed}");
    }

    public override void MarkCompleted()
    {
        Completed = true;
    }
}






