// array test
//一维数组

using System;
public class ArrayClass
{
    static void PrintArray(string[] w)
    {
        for (int i = 0; i < w.Length; i++)
            Console.Write(w[i] + " ");
    }

    public static void Main()
    {
        string[] WeekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};
        PrintArray(WeekDays);
        Console.ReadLine();
    }
}
