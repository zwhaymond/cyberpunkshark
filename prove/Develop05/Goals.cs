// Make sure the base class Goal is public
public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public bool Completed { get; set; }

    public Goal(string name, string description, int points, bool completed)
    {
        Name = name;
        Description = description;
        Points = points;
        Completed = completed;
    }

    public abstract void DisplayGoalWithCheckbox();
    public abstract void MarkCompleted();
}





    


