public class Activity(string activityType, string desctiptionType)
{
    private string _activityName = activityType;
    private string _description = desctiptionType;
    protected int _duration;
    void ActivitySummary(string[] args)
    {
        Console.WriteLine(_activityName);
        Console.WriteLine(_description);
        Console.WriteLine("How long would you like to do this activity?");
        _duration = int.Parse(Console.ReadLine());

        Beyblade(_duration);

    }   

    void Beyblade(int duration)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string frame = animation[i];
            Console.Write(frame);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animation.Count){
                i = 0;
            }
        }

    } 
}