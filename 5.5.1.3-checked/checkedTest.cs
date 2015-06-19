// checked test
//在运行时刻检查非常量表达式的溢出

using System;

class OverFlowTest
{
    static short x = 32767;   //最大值的short值
    static short y = 32767;
    public static int myMethodCh()
    {
        int z = checked((short)(x + y));
        return z;   //抛出OverflowException异常
    }
    public static int myMethodUnch()
    {
        int z = unchecked((short)(x + y));
        return z;   //返回-2
    }
    public static int myMethodDefault()
    {
        int z = (short)(x + y);
        return z;
    }

    const int cx = 2147483647;   //最大的int值
    const int cy = 2;
    public int MethodUnCh()
    {
        unchecked
        {
            int z = cx * cy;
            return z;   //返回-2
        }
    }
    public int MethodDef()
    {
        int z = 0;
        //z = cx * cy;
        return z;   //编译错误
    }
    public int MethodCh()
    {
        checked
        {
            int z = 0;
            //z = (cx * cy);
            return z;   //编译错误
        }
    }


    public static void Main()
    {
        try
        {
            Console.WriteLine("Checked output value is: {0}", myMethodCh());
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception caught:" + e);
        }

        Console.WriteLine();

        try
        {
            Console.WriteLine("UNchecked output value is: {0}", myMethodUnch());
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception caught:" + e);
        }

        Console.WriteLine();

        try
        {
            Console.WriteLine("default output value is: {0}", myMethodUnch());
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception caught in default:" + e);
        }

        Console.WriteLine();

        // compile time check for constants 
        OverFlowTest myObject = new OverFlowTest();
        Console.WriteLine("Unchecked output value: {0}", myObject.MethodUnCh());
        Console.WriteLine("Default output value: {0}", myObject.MethodDef());
        Console.WriteLine("Checked output value: {0}", myObject.MethodCh());

        Console.ReadLine();
    }
}
