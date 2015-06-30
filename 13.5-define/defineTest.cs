// define directive test

//使用/D:DEBUG进行编译
//#undef DEBUG
using System;
public class MyClass
{
    public static void Main()
    {
#if DEBUG
        Console.WriteLine("DEBUG is defined");
#else
        Console.WriteLine("DEBUG is not defined");
#endif
        Console.ReadLine();
    }
}
