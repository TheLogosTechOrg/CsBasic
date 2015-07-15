// property accessor test
//隐藏属性

using System;
public class BaseClass
{
    private string name;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
}
public class DerivedClass : BaseClass
{
    private string name;
    public new string Name   //注意使用new修饰符
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
}

abstract class Shape
{
    public abstract double Area
    {
        get;
        set;
    }
}
class Square : Shape
{
    public double side;

    public Square(double s)
    {
        side = s;
    }

    public override double Area
    {
        get
        {
            return side * side;
        }
        set
        {
            side = Math.Sqrt(value);
        }
    }
}
class Cube : Shape
{
    public double side;

    public Cube(double s)
    {
        side = s;
    }

    public override double Area
    {
        get
        {
            return 6 * side * side;
        }
        set
        {
            side = Math.Sqrt(value / 6);
        }
    }
}

public class MainClass
{
    public static void Main()
    {
        DerivedClass d1 = new DerivedClass();
        d1.Name = "John";
        Console.WriteLine("Name in the derived class is: {0}", d1.Name);
        ((BaseClass)d1).Name = "Mary"; 
        Console.WriteLine("Name in the base class is: {0}", ((BaseClass)d1).Name);
        Console.WriteLine();

        Console.Write("Enter the side: ");
        string sideString = Console.ReadLine();
        double side = double.Parse(sideString);
        Square s = new Square(side);
        Cube c = new Cube(side);
        Console.WriteLine("Area of a square = {0:00}", s.Area);
        Console.WriteLine("Area of a cube = {0:00}", c.Area);
        Console.WriteLine();

        Console.Write("Enter the area: ");
        string areaString = Console.ReadLine();
        double area = double.Parse(areaString);
        s.Area = area;
        c.Area = area;
        Console.WriteLine("Side of a square = {0:0.00}", s.side);
        Console.WriteLine("Side of a cube = {0:0.00}", c.side);

        Console.ReadLine();
    }
}
