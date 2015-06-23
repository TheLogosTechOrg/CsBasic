// is test
//is操作符

using System;
class Class1
{
}

class Class2
{
}

public class IsTest
{
    public static void Test(object o)
    {
        Class1 a;
        Class2 b;

        if (o is Class1)
        {
            Console.WriteLine("o is Class1");
            a = (Class1)o;
            //对a进行一些操作
        }

        else if (o is Class2)
        {
            Console.WriteLine("o is Class2");
            b = (Class2)o;
            //对b进行一些操作
        }

        else
        {
            Console.WriteLine("o is neither Class1 nor Class2");
        }
    }
    public static void Main()
    {
        Class1 c1 = new Class1();
        Class2 c2 = new Class2();
        Test(c1);
        Test(c2);
        Test("a string");
        Console.ReadLine();
    }
}
