// test object class

using System;

public class MyClass1 
{
    public int i = 10;
}

public class MyClass2 
{
    public static void Main() 
    {
        object a;
        a = 1;
        Console.WriteLine(a);
        Console.WriteLine(a.GetType());
        Console.WriteLine(a.ToString());
        Console.WriteLine();
        
        a = new MyClass1 ();
        MyClass1 ref_MyClass1;
        ref_MyClass1 = (MyClass1)a;
        Console.WriteLine(ref_MyClass1.i);
        Console.WriteLine(a);
        Console.WriteLine(a.GetType());
        Console.WriteLine(a.ToString());

        Console.ReadLine();
   }
}
