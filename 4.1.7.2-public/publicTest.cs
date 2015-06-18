// public member
//公开访问

using System;
class MyClass1
{
    public int x;
    public int y;
}

class MyClass2
{
    public static void Main()
    {
        MyClass1 mC = new MyClass1();

        //直接访问公开成员
        mC.x = 10;
        mC.y = 15;
        Console.WriteLine("x = {0}, y = {1}", mC.x, mC.y);
        Console.ReadLine();
    }
}
