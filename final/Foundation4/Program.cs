using System;

class Program
{
    static void Main(string[] args)
    {
        // List of all completed activites
        List<Activity> _activities = new List<Activity>();

        // Running 30 minutes 2.5 miles
        RunActivity ractivity = new RunActivity("Running", "March 20, 2023", 30, 2);
        _activities.Add(ractivity);

        // Biking 45 minutes 5 mph
        BikeActivity bactivity = new BikeActivity("Biking", "March 21, 2023", 45, 5);
        _activities.Add(bactivity);

        // Swimming 30 minutes 20 laps
        SwimActivity sactivity = new SwimActivity("Swimming", "March 22, 2023", 30, 20);
        _activities.Add(sactivity);


        // Display the summary for each activity
        Console.WriteLine("");
        
        foreach (Activity activity in _activities)
        {
            activity.GetSummary();
            Console.WriteLine("");
        }

        Console.WriteLine();
    }
}