// extern test: using c dll

using System;
using System.Runtime.InteropServices;
public class MyClass
{
    [DllImport("cdll.dll", CallingConvention = CallingConvention.Cdecl)] // without the second part will have a PInvokeStackImbalance warning
    public static extern int MyMethod(int x);
    [DllImport("cdll.dll")] // this seems to be going well without the warning
    public static extern int MyMethodWithNoParameter();

    public static void Main()
    {
        int result1 = MyMethodWithNoParameter();
        Console.WriteLine("MyMethodWithNoParameter() returns {0}.", result1.ToString());

        int result = MyMethod(5);
        Console.WriteLine("MyMethod(5) returns {0}.", result.ToString());

        Console.ReadLine();
    }
}
