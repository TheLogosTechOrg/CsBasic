// const test
//常量

using System;
public class ConstTest
{
    class MyClass
    {
        public int x;
        public int y;
        public const int c1 = 5;
        public const int c2 = c1 + 5;

        public MyClass(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }

    public static void Main()
    {
        MyClass mC = new MyClass(11, 22);
        Console.WriteLine("x = {0}, y = {1}", mC.x, mC.y);
        Console.WriteLine("c1 = {0}, c2 = {1}", MyClass.c1, MyClass.c2);
        //MyClass.c1 = 15; // error

        const int c = 707;
        //c = 808; // error
        Console.WriteLine("My local constant = {0}", c);

        Console.ReadLine();
    }
}
