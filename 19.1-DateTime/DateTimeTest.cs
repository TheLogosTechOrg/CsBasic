// DateTime test

using System;

public class DisplayCurrentTime
{
    public static void Main(String[] args)
    {
        DateTime dtCurrTime = DateTime.Now;
        Console.WriteLine("Current Time is " + dtCurrTime.ToString());

        Console.WriteLine("Year is " + dtCurrTime.Year.ToString());
        Console.WriteLine("Month is " + dtCurrTime.Month.ToString());
        Console.WriteLine("Day of month is " + dtCurrTime.Day.ToString());
        Console.WriteLine("Day of week is " + dtCurrTime.DayOfWeek.ToString());
        Console.WriteLine("Hour is " + dtCurrTime.Hour.ToString());
        Console.WriteLine("Minute is " + dtCurrTime.Minute.ToString());
        Console.WriteLine("Second is " + dtCurrTime.Second.ToString());
        Console.WriteLine("Millisecond is " + dtCurrTime.Millisecond.ToString());

        Console.WriteLine("ShortDateString is " + dtCurrTime.ToShortDateString());
        Console.WriteLine("LongDateString is " + dtCurrTime.ToLongDateString());
        Console.WriteLine("ShortTimeString is " + dtCurrTime.ToShortTimeString());
        Console.WriteLine("LongTimeString is " + dtCurrTime.ToLongTimeString());

        Console.ReadLine();
    }
}
