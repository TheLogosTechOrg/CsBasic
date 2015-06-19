// unsafe test

using System;
class UnsafeTest
{
    //非保护方法：使用int指针
    unsafe static void SquarePtrParam(int* p)
    {
        *p *= *p;
    }

    static unsafe void Copy(byte[] src, int srcIndex,
                            byte[] dst, int dstIndex, int count)
    {
        if (src == null || srcIndex < 0 ||
            dst == null || dstIndex < 0 || count < 0)
        {
            throw new ArgumentException();
        }
        int srcLen = src.Length;
        int dstLen = dst.Length;
        if (srcLen - srcIndex < count ||
            dstLen - dstIndex < count)
        {
            throw new ArgumentException();
        }
        //固定源数组和目标数组的内存位置，
        //防止在拷贝过程中src和dst对象被垃圾回收器移动。
        fixed (byte* pSrc = src, pDst = dst)
        {
            byte* ps = pSrc;
            byte* pd = pDst;
            for (int n = count >> 2; n != 0; n--)
            {
                *((int*)pd) = *((int*)ps);
                //每次拷贝一个整数，int为四个字节。
                pd += 4;
                ps += 4;
            }
            for (count &= 3; count != 0; count--)
            {
                *pd = *ps;
                //拷贝上一步没有拷贝完的数据
                pd++;
                ps++;
            }
        }
    }

    public static void Main() 
    {
        int n = 5;
        unsafe
        {
            SquarePtrParam(&n);
        }
        Console.WriteLine (n);
        Console.WriteLine();

        byte[] a = new byte[100];
        byte[] b = new byte[100];
        for (int i = 0; i < 100; ++i)
            a[i] = (byte)i;
        Console.WriteLine("The first 10 elements of a are:");
        for (int i = 0; i < 10; ++i)
            Console.Write(a[i] + " ");
        Console.WriteLine();
        Copy(a, 0, b, 0, 100);
        Console.WriteLine("The first 10 elements of b are:");
        for (int i = 0; i < 10; ++i)
            Console.Write(b[i] + " ");

        Console.ReadLine();
    }
}
