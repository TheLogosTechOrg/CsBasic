// sizeof test
//使用sizeof操作符

using System;

class SizeClass
{
    //注意方法的非保护声明
    unsafe public static void SizesOf()
    {
        Console.WriteLine("The size of short is {0}.", sizeof(short));
        Console.WriteLine("The size of int is {0}.", sizeof(int));
        Console.WriteLine("The size of long is {0}.", sizeof(long));
    }
}

class MainClass
{
    public static void Main()
    {
        SizeClass.SizesOf();
        Console.ReadLine();
    }
}
