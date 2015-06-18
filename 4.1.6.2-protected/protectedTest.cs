// protected member

using System;
class MyClass
{
    protected int x;
    protected int y;
}

class MyDerivedClass : MyClass
{
    public static void Main()
    {
        MyClass c = new MyClass();
        MyDerivedClass dc = new MyDerivedClass();

        //c.x = 1; // error

        //直接访问保护成员
        dc.x = 10;
        dc.y = 15;
        Console.WriteLine("x = {0}, y = {1}", dc.x, dc.y);
        Console.ReadLine();
    }
}
