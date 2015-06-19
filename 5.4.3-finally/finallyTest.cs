// finally test

using System;
public class TestTryFinally
{
    public static void Main()
    {
        int i = 123;
        string s = "Some string";
        object o = s;

        try
        {
            Console.WriteLine("Executing the try statement.");
            //非法转换；o包含字符串而不是整数
            i = (int)o;
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine("Caught exception #1./n{0}", e);
        }
        catch
        {
            Console.WriteLine("Caught exception #2.");
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
            Console.Write("i = {0}", i);
        }

        Console.ReadLine();
    }
}
