// typeof test

using System;
using System.Reflection;

public class MyClass
{
    public int intI;
    public void MyMeth()
    {
    }

    public static void Main()
    {
        Type t = typeof(MyClass);

        //除了这种方法外，你也可以使用
        MyClass instance1 = new MyClass();
        Type t1 = instance1.GetType();   

        MethodInfo[] x = t.GetMethods();
        foreach (MethodInfo xtemp in x)
        {
            Console.WriteLine(xtemp.ToString());
        }

        Console.WriteLine();

        MemberInfo[] x2 = t1.GetMembers();
        foreach (MemberInfo xtemp2 in x2)
        {
            Console.WriteLine(xtemp2.ToString());
        }

        Console.WriteLine();

        int radius = 3;
        Console.WriteLine("Area = {0} ", radius*radius*Math.PI);
        Console.WriteLine("The type is {0}", (radius*radius*Math.PI).GetType());

        Console.ReadLine();
    }
}
