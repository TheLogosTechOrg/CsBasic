// return test

using System;

class ReturnTest
{
    static double CalculateArea(int r)
    {
        double area;
        area = r * r * Math.PI;
        return area;
    }

    public static void Main()
    {
        int radius = 5;
        Console.WriteLine("The area is {0:0.00}", CalculateArea(radius));
        Console.ReadLine();
    }
}
