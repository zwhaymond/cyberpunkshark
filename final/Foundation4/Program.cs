using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store activities
        List<Activity> activities = new List<Activity>();

        // Adding activities to the list
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));   // 3 miles running
        activities.Add(new Cycling(new DateTime(2022, 11, 3), 30, 12.0));   // 12 mph cycling
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 30, 20));    // 20 laps swimming

        // Iterate through activities and print summary
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
