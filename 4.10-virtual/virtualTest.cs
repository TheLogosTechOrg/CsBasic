// virtual test
//虚方法和覆盖

using System;
class TestClass
{
    public class Dimensions
    {
        public const double pi = Math.PI;
        protected double x, y;
        public Dimensions()
        {
        }
        public Dimensions(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double Area()
        {
            return x * y;
        }
    }

    public class Circle : Dimensions
    {
        public Circle(double r)
            : base(r, 0)
        {
        }

        public override double Area()
        {
            return pi * x * x;
        }
    }

    class Sphere : Dimensions
    {
        public Sphere(double r)
            : base(r, 0)
        {
        }

        public override double Area()
        {
            return 4 * pi * x * x;
        }
    }

    class Cylinder : Dimensions
    {
        public Cylinder(double r, double h)
            : base(r, h)
        {
        }

        public override double Area()
        {
            return 2 * pi * x * x + 2 * pi * x * y;
        }
    }

    public static void Main()
    {
        double r = 3.0, h = 5.0;
        Dimensions c = new Circle(r);
        Dimensions s = new Sphere(r);
        Dimensions l = new Cylinder(r, h);

        Console.WriteLine("Area of Circle   = {0}", string.Format("{0:0.00}", c.Area()));
        Console.WriteLine("Area of Sphere   = {0}", string.Format("{0:0.00}", s.Area()));
        Console.WriteLine("Area of Cylinder = {0}", string.Format("{0:0.00}", l.Area()));

        Console.ReadLine();
    }
}
