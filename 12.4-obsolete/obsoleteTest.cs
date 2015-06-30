// obsolete test

using System;
public class MyClass
{
    // [Obsolete("Don't use OldWay; use NewWay instead", true)] 
    [Obsolete("Don't use OldWay; use NewWay instead", false)]
    static void OldWay() { Console.WriteLine("Silly me!"); }
    static void NewWay() { Console.WriteLine("D'oh!"); }
    public static void Main()
    {
        Console.WriteLine("In Main()");
        OldWay();
        Console.ReadLine();
    }
}
