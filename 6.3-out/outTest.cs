// out test
using System;

public class MyClass
{
    public static int TestOut(out char i)
    {
        i = 'b';
        return -1;
    }

    public static void Main()
    {
        char i;
        Console.WriteLine(TestOut(out i));
        Console.WriteLine(i);
        Console.ReadLine();
    }
}
