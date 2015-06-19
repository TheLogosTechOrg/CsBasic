// do-while test

using System;
public class TestDoWhile
{
    public static void Main()
    {
        int x;
        int y = 0;

        do
        {
            x = y++; // NOTE: first x = y, then y++. so the first x value is 0, not 1.
            Console.WriteLine(x);
        }
        while (y < 5);

        Console.WriteLine();

        int n = 10;
        do // will be executed at least once no matter what. 
        {
            Console.WriteLine("Current value of n is {0}", n);
            n++;
        } while (n < 6);

        Console.ReadLine();
    }
}
