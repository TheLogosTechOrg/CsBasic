// conditional test

#define DEBUG
using System;
using System.Diagnostics;
public class Trace
{
    [Conditional("DEBUG")]
    public static void Msg(string msg)
    {
        Console.WriteLine(msg);
    }
}

class Test
{
    static void A()
    {
        Trace.Msg("Now in A.");
        B();
    }
    static void B()
    {
        Trace.Msg("Now in B.");
    }
    public static void Main()
    {
        Trace.Msg("Now in Main.");
        A();
        Console.WriteLine("Done.");
        Console.ReadLine();
    }
}
