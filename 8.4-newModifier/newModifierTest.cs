//new as a modifier test

using System;

public class MyBaseC
{
    public static int x = 55;
    public static int y = 22;
}

public class MyDerivedC : MyBaseC
{
    new public static int x = 100;   //隐藏名称
    public static void Main()
    {
        //显示x的覆盖值
        Console.WriteLine(x);

        //访问x被隐藏的值
        Console.WriteLine(MyBaseC.x);

        //显示未被隐藏的y成员
        Console.WriteLine(y);

        Console.ReadLine();
    }
}
