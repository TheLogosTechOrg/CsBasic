// Main() test

using System;
public class Factorial
{
    public static long Fac(long i)
    {
        return ((i <= 1) ? 1 : (i * Fac(i - 1)));
    }
}

class MyClass
{
    public static void Main()
    {
        Console.Write("Enter an integer: ");

        string s = Console.ReadLine();

        long num = Int64.Parse(s);

        Console.WriteLine("The Factorial of {0} is {1}.", num, Factorial.Fac(num));

        Console.ReadLine();
    }
}
