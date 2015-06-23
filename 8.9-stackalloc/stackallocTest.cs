// stackalloc test

using System;   //使用/unsafe选项编译
class Test
{
    public static unsafe void Main()
    {
        int* fib = stackalloc int[100];
        int* p = fib;
        *p++ = *p++ = 1; // p[1] = p[0] = 1; 
        for (int i = 2; i < 100; ++i, ++p)
            *p = p[-1] + p[-2];
        for (int i = 0; i < 10; ++i)
            Console.WriteLine(fib[i]);
        Console.ReadLine();
    }
}
