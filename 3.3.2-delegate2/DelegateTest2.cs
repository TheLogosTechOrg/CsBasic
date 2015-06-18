// delegate multicast with operations + and -

using System;

// do something to a string
delegate void MyDelegate(string s);

class MyClass
{
    public static void Hello(string s)
    {
        Console.WriteLine("  Hello, {0}!", s);
    }

    public static void Goodbye(string s)
    {
        Console.WriteLine("  Goodbye, {0}!", s);
    }

    public static void Main()
    {
        MyDelegate a, b, c, d;

        a = new MyDelegate(Hello);
        b = new MyDelegate(Goodbye);
        c = a + b; // do two things together!
        d = c - a; // = b

        Console.WriteLine("Invoking delegate a:");
        a("A");
        Console.WriteLine("Invoking delegate b:");
        b("B");
        Console.WriteLine("Invoking delegate c:");
        c("C");
        Console.WriteLine("Invoking delegate d:");
        d("D");
        Console.ReadLine();
    }
}
