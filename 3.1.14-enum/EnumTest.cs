// enum test
// Ã¶¾Ù³õÊ¼»¯

using System;

public class EnumTest 
{
    // default enum with int as base type
    enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri };
    enum Days1 {Sat=1, Sun, Mon, Tue, Wed, Thu, Fri};
    // using long as base type
    enum Range : long { Max = 2147483648L, Min = 255L };

    public static void Main() 
    {
        int x = (int) Days.Sun;
        int y = (int) Days.Fri;
        Console.WriteLine("By default:");
        Console.WriteLine("Sun = {0}", x);
        Console.WriteLine("Fri = {0}", y);

        int x1 = (int)Days1.Sun;
        int y1 = (int)Days1.Fri;
        Console.WriteLine("In Days1:");
        Console.WriteLine("Sun = {0}", x1);
        Console.WriteLine("Fri = {0}", y1);

        long xl = (long)Range.Max;
        long yl = (long)Range.Min;
        Console.WriteLine("As long:");
        Console.WriteLine("Max = {0}", xl);
        Console.WriteLine("Min = {0}", yl);

        Console.ReadLine();
    }
}
