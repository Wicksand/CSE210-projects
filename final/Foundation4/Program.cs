using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        //example data -----------------------------------------
        activities.Add(new RunningActivity("03 Nov 2022", 20, 2));
        activities.Add(new CyclingActivity("25 Jan 2004",60 , 4));
        activities.Add(new SwimmingActivity("09 Sep 2024", 30, 35));
        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }


    }
}