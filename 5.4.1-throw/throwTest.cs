// throw test
//抛出异常

using System;
public class ThrowTest
{
    public static void Main()
    {
        string s = null;

        if (s == null)
        {
            throw (new ArgumentNullException());
        }

        Console.Write("The string s is null"); //不会执行
    }
}
