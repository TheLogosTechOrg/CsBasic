// Main() with arguments
//命令行参数

using System;
public class Factorial
{
    public static long Fac(long i)
    {
        return ((i <= 1) ? 1 : (i * Fac(i - 1)));
    }
}

class MainClass
{
    public static int Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please enter a numeric argument.");
            Console.WriteLine("Usage: Factorial <num>");
            Console.ReadLine();
            return 1;
        }

        long num = long.Parse(args[0]);
        Console.WriteLine("The Factorial of {0} is {1}.", num, Factorial.Fac(num));
        Console.ReadLine();
        return 0;
    }
}
