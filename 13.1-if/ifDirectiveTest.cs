// if directive test

#define DEBUG
#define VC_V6

using System;

public class MyClass
{
    public static void Main()
    {
#if (DEBUG && !VC_V6)
        Console.WriteLine("DEBUG is defined");
#elif (!DEBUG && VC_V6)
        Console.WriteLine("VC_V6 is defined");
#elif (DEBUG && VC_V6)
        Console.WriteLine("DEBUG and VC_V6 are defined");
#else
        Console.WriteLine("DEBUG and VC_V6 are not defined");
#endif
        Console.ReadLine();
    }
}
