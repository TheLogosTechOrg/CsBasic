// operator test

using System;
class Test
{
    public static void Main()
    {
        // ()
        double x = 1234.7;
        int a;
        a = (int)x; // cast double to int
        Console.WriteLine(a);
        Console.WriteLine();

        // +
        Console.WriteLine(+5);        //一元加
        Console.WriteLine(5 + 5);      //加法
        Console.WriteLine(5 + .5);     //加法
        Console.WriteLine("5" + "5");  // 字符串连接
        Console.WriteLine(5.0 + "5");  //字符串连接 //注意，自动把double转换成字符串
        Console.WriteLine();

        // -
        a = 5;
        Console.WriteLine(-a);
        Console.WriteLine(a - 1);
        Console.WriteLine(a - .5);
        Console.WriteLine();

        // *
        Console.WriteLine(5 * 2);
        Console.WriteLine(-.5 * .2);
        Console.WriteLine(-.5m * .2m); //decimal类型
        Console.WriteLine();

        // /
        Console.WriteLine(-5 / 2);
        Console.WriteLine(-5.0 / 2);
        Console.WriteLine();

        // %
        Console.WriteLine(5 % 2);   // int
        Console.WriteLine(-5 % 2);   // int
        Console.WriteLine(5.0 % 2.2);   // double
        Console.WriteLine(5.0m % 2.2m);   // decimal
        Console.WriteLine(-5.2 % 2.0);   // double
        Console.WriteLine();

        // & 
        Console.WriteLine(true & false); //逻辑and
        Console.WriteLine(true & true);  //逻辑and
        Console.WriteLine("0x{0:x}", 0xf8 & 0x3f);  //按位and: 1111 1000 AND 0011 1111 = 0011 1000
        Console.WriteLine();

        // | 
        Console.WriteLine(true | false);  //逻辑or
        Console.WriteLine(false | false); //逻辑or
        Console.WriteLine("0x{0:x}", 0xf8 | 0x3f);   //按位or
        Console.WriteLine();

        // ^
        Console.WriteLine(true ^ false);  //逻辑异或
        Console.WriteLine(false ^ false); //逻辑异或
        Console.WriteLine("0x{0:x}", 0xf8 ^ 0x3f);   //按位异或 = 1100 0111 
        Console.WriteLine();

        // !
        Console.WriteLine(!true);
        Console.WriteLine(!false);
        Console.WriteLine();

        // ~ 
        Console.WriteLine("!0x{0:x8} = 0x{1:x8}", 8, ~8);
        Console.WriteLine("!0x{0:x8} = 0x{1:x8}", -8, ~-8);
        Console.WriteLine();

        // = 
        int i;
        i = 5; // int到int的赋值
        x = i; // int隐式转换成double
        i = (int)x; // 需要强制转换
        Console.WriteLine("i is {0}, x is {1}", i, x);
        object obj = i;
        Console.WriteLine("boxed value = {0}, type is {1}", obj, obj.GetType());
        i = (int)obj;
        Console.WriteLine("unboxed: {0}", i);
        Console.WriteLine();

        // <
        Console.WriteLine(1 < 1.1);
        Console.WriteLine(1.1 < 1.1);
        Console.WriteLine();

        // >
        Console.WriteLine(1.1 > 1);
        Console.WriteLine(1.1 > 1.1);
        Console.WriteLine();

        // ? : 
        Console.WriteLine(sinc(0.2));
        Console.WriteLine(sinc(0.1));
        Console.WriteLine(sinc(0.0));
        Console.WriteLine();

        // ++
        x = 1.5;
        Console.WriteLine(++x);
        Console.WriteLine(x);
        x = 1.5;
        Console.WriteLine(x++);
        Console.WriteLine(x);
        Console.WriteLine();

        // --
        x = 1.5;
        Console.WriteLine(--x);
        Console.WriteLine(x);
        x = 1.5;
        Console.WriteLine(x--);
        Console.WriteLine(x);
        Console.WriteLine();

        // &&
        Console.WriteLine("regular AND:");
        Console.WriteLine("result is {0}", fn1() & fn2());
        Console.WriteLine("short-circuit AND:");
        Console.WriteLine("result is {0}", fn1() && fn2());
        Console.WriteLine();

        // ||
        Console.WriteLine("regular OR:");
        Console.WriteLine("result is {0}", fn1() | fn2());
        Console.WriteLine("short-circuit OR:");
        Console.WriteLine("result is {0}", fn2() || fn1());
        Console.WriteLine();

        // << 
        i = 1;
        long lg = 1;
        Console.WriteLine("0x{0:x}", i << 1);
        Console.WriteLine("0x{0:x}", i << 33);
        Console.WriteLine("0x{0:x}", lg << 33);
        Console.WriteLine();

        // >>
        i = -1000;
        Console.WriteLine(i >> 3);
        Console.WriteLine();

        // == 
        // 数值相等：True
        Console.WriteLine((2 + 2) == 4);
        // 引用相等:不同对象，具有相同的值：False
        object s = 1;
        object t = 1;
        Console.WriteLine(s == t);
        // 定义字符串
        string sa = "hello";
        string sb = String.Copy(sa);
        string sc = "hello";
        // 比较常量和实例中字符串内容：True
        Console.WriteLine(sa == sb);
        Console.WriteLine(sa == sc);
        // 比较字符串引用 
        // a是常量而b是实例：False
        Console.WriteLine((object)sa == (object)sb);
        // 比较字符串引用，两个常量的值相同，
        // 所以字符串指向同一个引用：True
        Console.WriteLine((object)sa == (object)sc); // TRUE!!!
        Console.WriteLine();

        // !=
        // 数值不相等
        Console.WriteLine((2 + 2) != 4);
        // 引用相等：两个对象，包含相同的值
        s = 1;
        t = 1;
        Console.WriteLine(s != t);
        // 字符串相等：相同的字符串值，相同的字符串对象
        sa = "hello";
        sb = "hello";
        sc = string.Copy(sa);
        // 比较字符串的内容
        Console.WriteLine(sa != sb);
        Console.WriteLine(sa != sc);
        // 比较字符串引用
        Console.WriteLine((object)sa != (object)sb); // FALSE!!! 
        Console.WriteLine((object)sa != (object)sc);
        Console.WriteLine();

        // <= 
        Console.WriteLine(1 <= 1.1);
        Console.WriteLine(1.1 <= 1.1);
        Console.WriteLine();

        // >=
        Console.WriteLine(1.1 >= 1);
        Console.WriteLine(1.1 >= 1.1);
        Console.WriteLine();

        // +=
        i = 5;
        i += 6;
        Console.WriteLine(i);
        string st = "Micro";
        st += "soft";
        Console.WriteLine(st);
        Console.WriteLine();

        // -=
        i = 5;
        i -= 6;
        Console.WriteLine(i);
        Console.WriteLine();

        // *= 
        i = 5;
        i *= 6;
        Console.WriteLine(i);
        Console.WriteLine();

        // /=
        i = 5;
        i /= 6;
        Console.WriteLine(i);
        double b = 5;
        b /= 6;
        Console.WriteLine(b);
        Console.WriteLine();

        // %= 
        i = 5;
        i %= 3;
        Console.WriteLine(i);
        Console.WriteLine();

        // &=
        int aa = 0x0c; // 1100
        aa &= 0x06;    // 0110
        Console.WriteLine("0x{0:x8}", aa); // 0100
        bool bb = true;
        bb &= false;
        Console.WriteLine(bb);
        Console.WriteLine();

        // |= 
        aa = 0x0c;
        aa |= 0x06;
        Console.WriteLine("0x{0:x8}", aa); // 1110
        bb = true;
        bb |= false;
        Console.WriteLine(bb);
        Console.WriteLine();

        // ^= 
        aa = 0x0c;
        aa ^= 0x06;
        Console.WriteLine("0x{0:x8}", aa); // 1010
        bb = true;
        bb ^= false;
        Console.WriteLine(b);
        Console.WriteLine();

        // <<=
        aa = 1000; // 0000 0011 1110 1000 
        aa <<= 4;  // 0011 1110 1000 0000
        Console.WriteLine(aa);
        Console.WriteLine();

        // >>= 
        aa = 1000;
        aa >>= 4;  // 0000 0000 0011 1110
        Console.WriteLine(aa);
        Console.WriteLine();

        // ->
        Point pt = new Point();
        unsafe
        {
            Point* pp = &pt;
            pp->x = 123;
            pp->y = 456;
        }
        Console.WriteLine("{0} {1}", pt.x, pt.y);

        Console.ReadLine();
    }

    public static double sinc(double x)
    {
        return x != 0.0 ? Math.Sin(x) / x : 1.0;
    }

    static bool fn1()
    {
        Console.WriteLine("fn1 called");
        return false;
    }

    static bool fn2()
    {
        Console.WriteLine("fn2 called");
        return true;
    }

    struct Point
    {
        public int x, y;
    }

}
