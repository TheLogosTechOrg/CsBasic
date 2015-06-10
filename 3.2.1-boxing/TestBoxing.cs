// boxing int to object, and unboxing object to int
// 包装整数变量

using System;

class TestBoxing  
{
    public static void Main() 
    {
        int i = 123;
        object o = i; // boxing
        i = 456;
        Console.WriteLine("The value-type value = {0}", i);
        Console.WriteLine("The object-type value = {0}", o);

        try
        {
            int ui = (int)o;
            Console.WriteLine("Unboxing to int OK.");
            int uj = (short)o;
            Console.WriteLine("Unboxing to short OK."); // will not reach
        }
        catch (InvalidCastException e)
        {
            Console.WriteLine("Error: Incorrect unboxing.");
            Console.WriteLine("{0}", e);
        }

        Console.ReadLine();
    }
}
