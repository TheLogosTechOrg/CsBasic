// TimeSpan test

using System;

public class TimeSpanSample
{
    public static void Main(String[] args)
    {
        TimeSpan Span = new TimeSpan(4, 2, 15, 0);
        DateTime dtOld = new DateTime(2000, 1, 1, 12, 0, 0, 0);
        DateTime dtNew = dtOld + Span;
        Console.WriteLine("Original date was " + dtOld.ToLongDateString() + "  " + dtOld.ToShortTimeString());
        Console.WriteLine("Adding time span of " + Span.ToString());
        Console.WriteLine("Result is " + dtNew.ToLongDateString() + "  " + dtNew.ToShortTimeString());
        Console.WriteLine("");

        Console.WriteLine("Time span broken down is:");
        Console.WriteLine("Days: " + Span.Days.ToString());
        Console.WriteLine("Hours: " + Span.Hours.ToString());
        Console.WriteLine("Minutes: " + Span.Minutes.ToString());
        Console.WriteLine("Seconds: " + Span.Seconds.ToString());
        Console.WriteLine("Milliseconds: " + Span.Milliseconds.ToString());
        Console.WriteLine("Ticks: " + Span.Ticks.ToString());
        Console.WriteLine("");

        Console.WriteLine("TicksPerSecond: " + TimeSpan.TicksPerSecond.ToString());
        Console.WriteLine("TicksPerHour: " + TimeSpan.TicksPerHour.ToString());
        Console.WriteLine("");

        Console.WriteLine("The program starts.");
        DateTime start = DateTime.Now;
        for (int i = 0; i < 5000; i++)
        {
            for (int j = 0; j < 5000; j++)
            {
                double y = Math.Sin(i + j);
            }
        }
        DateTime end = DateTime.Now;

        Console.WriteLine("The program ends.");
        Span = end - start;
        Console.WriteLine("Running time: " + Span.ToString());
        Console.WriteLine("Seconds: " + Span.Seconds.ToString());
        Console.WriteLine("Milliseconds: " + Span.Milliseconds.ToString());
        Console.WriteLine("Ticks: " + Span.Ticks.ToString());

        Console.ReadLine();
    }
}