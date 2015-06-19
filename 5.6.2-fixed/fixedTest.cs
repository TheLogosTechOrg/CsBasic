// fixed test

using System;

class Point
{
    public int x, y;
}

class FixedTest
{
    unsafe static void SquarePtrParam(int* p)
    {
        *p *= *p;
    }

    public static void Main()
    {
        Point pt = new Point();
        pt.x = 5;
        pt.y = 6;

        unsafe
        {
            //int* p = &pt.x; // error
            //固定pt
            fixed (int* p = &pt.x)
            {
                SquarePtrParam(p);
            }
            //pt不再固定
        }

        Console.WriteLine("{0} {1}", pt.x, pt.y);
        Console.ReadLine();
    }
}
