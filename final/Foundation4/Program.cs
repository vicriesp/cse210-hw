using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       Console.Clear();
       List<Activity> activity = new List<Activity>();
       Console.WriteLine(activity);
       Console.Clear();

       Running a1 = new Running("03 Nov 2023", 30, 25, 10);
       activity.Add(a1);
       
       Cycling a2 = new Cycling ("12 Jan 2023", 25, 40, 25);
       activity.Add(a2);
       Console.WriteLine(" ");

       Swimming a3 = new Swimming("25 Feb 2023", 10, 2, 15, 10);
       activity.Add(a3);
       Console.WriteLine(" ");
    
    foreach (Activity a in activity)
    {
        string date = a.GetDate();
        double length = a.GetLength();

        string line = a.GetSummary();
        Console.WriteLine($"{date}, ({length} min), {line}");
        Console.WriteLine(a);
        Console.WriteLine(" ");
    }
    }
}