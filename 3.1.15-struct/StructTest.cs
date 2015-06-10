// struct test
// struct声明和初始化

using System;

// NOTE: the struct is defined outside the MainClass
// it would be ok as well if the struct is defined inside the MainClass
public struct Point
{
    public int x, y;
    public Point(int p1, int p2)
    {
        x = p1;
        y = p2;
    }
}

class MainClass 
{
    public static void Main()  
    {
        Point myPoint = new Point();
        Point yourPoint = new Point(10,10);
        // NOTE: different from a class, using new is not necessary for struct
        Point anotherPoint;
        anotherPoint.x = 10;
        anotherPoint.y = 20;

        Console.Write("My Point:\t");
        Console.WriteLine("x = {0}, y = {1}", myPoint.x, myPoint.y);
        Console.Write("Your Point:\t");
        Console.WriteLine("x = {0}, y = {1}", yourPoint.x, yourPoint.y);
        Console.Write("Another Point:\t");
        Console.WriteLine("x = {0}, y = {1}", anotherPoint.x, anotherPoint.y);
        Console.ReadLine();
    }
}
