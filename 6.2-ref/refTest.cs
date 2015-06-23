// ref test

using System;
public class MyClass
{
    public static void TestRef(ref char i)
    {
        //i的值将返回方法的调用者
        i = 'b';
    }

    public static void TestNoRef(char i)
    {
        //返回调用者后，i仍然是原来的值
        i = 'c';
    }

    public static void Main()
    {

        char i = 'a';
        TestRef(ref i);
        Console.WriteLine(i); // b
        TestNoRef(i);
        Console.WriteLine(i); // still b
        Console.ReadLine();
    }
}
