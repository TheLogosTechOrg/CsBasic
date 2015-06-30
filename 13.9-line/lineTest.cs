// line directive test

using System;
public class MyClass
{
    public static void Main()
    {
#line 100 "abc.sc"   // 修改编译器输出的文件名称 // NOTE: Using a new file name will break the link from Error List window to the code file. 
        intt i; // line 100
        Console.WriteLinee(); // line 101
    }
}
