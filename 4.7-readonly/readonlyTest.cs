// readonly test
//只读域

using System;
public class ReadOnlyTest
{
    class MyClass
    {
        public int x;
        public readonly int y = 25; //初始化只读域
        public readonly int z;

        public MyClass()
        {
            z = 24;   //初始化只读实例域
        }

        public MyClass(int p1, int p2, int p3)
        {
            x = p1;
            y = p2;
            z = p3;
        }
    }

    public static void Main()
    {
        MyClass p1 = new MyClass(11, 21, 32);
        Console.WriteLine("p1: x={0}, y={1}, z={2}", p1.x, p1.y, p1.z);
        MyClass p2 = new MyClass();
        p2.x = 55; // ok
        //p2.y = 66; // error
        //p2.z = 77; // error
        Console.WriteLine("p2: x={0}, y={1}, z={2}", p2.x, p2.y, p2.z);
        Console.ReadLine();
    }
}
