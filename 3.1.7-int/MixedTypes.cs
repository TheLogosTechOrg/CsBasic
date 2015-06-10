// calculation with mixed number types
// 多种类型混合运算

using System;

class MixedTypes 
{
    public static void Main() 
    {
        int x = 3;
        float y = 4.5f;
        short z = 5;
        Console.WriteLine("The result is {0}", x*y/z);

        double w = 1.7E+3;
        Console.WriteLine("The sum is {0}", x + y + z + w);

        Console.ReadLine();
    }
}
