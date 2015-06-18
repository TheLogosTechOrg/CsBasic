// override test
//调用基类中被覆盖的方法

using System;
class TestClass
{
    public class Square
    {
        public double x;

        //构造函数：
        public Square(double x)
        {
            this.x = x;
        }

        public virtual double Area()
        {
            return x * x;
        }
    }

    class Cube : Square
    {
        //构造函数：
        public Cube(double x)
            : base(x)
        {
        }

        //调用基类中的Area方法：
        public override double Area()
        {
            return (6 * (base.Area()));
        }
    }

    public static void Main()
    {
        double x = 5.2;
        Square s = new Square(x);
        Square c = new Cube(x);
        Console.WriteLine("Area of Square = {0}", string.Format("{0:0.00}", s.Area()));
        Console.WriteLine("Area of Cube = {0}", string.Format("{0:0.00}", c.Area()));
        Console.ReadLine();
    }
}
