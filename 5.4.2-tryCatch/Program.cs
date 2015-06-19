// try-catch test
//抛出处理，异常处理中显示消息

using System;
class MyClass
{
    public static void Main()
    {
        MyClass x = new MyClass();
        try
        {
            string s = null;
            x.MyFn(s);
            Console.WriteLine("this line will not be reached");
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine("First exception caught:\n{0}", e);
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception caught:\n{0}", e);
        }
        Console.ReadLine();
    }

    public void MyFn(string s)
    {
        if (s == null)
            //throw (new ArgumentNullException()); // will be catched by the first catch block
            throw new Exception(); // will be catched by the second catch blosk
    }
}
