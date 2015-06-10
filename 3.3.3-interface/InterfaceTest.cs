// interface test
// 接口的实现

using System;

interface IPoint 
{
    int x 
    {
        get; 
        set; 
    }
    int y 
    {
        get; 
        set; 
    }
}

class MyPoint : IPoint 
{
    private int myX;
    private int myY;
    public MyPoint(int x, int y) 
    {
        myX = x;
        myY = y;
    }
    public int x 
    {
        get 
        {
            return myX;
        }
        set 
        {
            myX = value; 
        }
    }
    public int y 
    {
        get 
        {
            return myY; 
        }
        set 
        {
            myY = value; 
        }
    }
}

class MainClass 
{
    private static void PrintPoint(IPoint p) 
    {
        Console.WriteLine("x={0}, y={1}", p.x, p.y);
    }

    public static void Main() 
    {
        MyPoint p = new MyPoint(2,3);
        Console.Write("My Point: ");
        PrintPoint(p);
        Console.ReadLine();
    }
}
