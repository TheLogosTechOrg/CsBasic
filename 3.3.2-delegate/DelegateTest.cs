// delegate test
// 通过代表调用静态和实例方法
using System;

delegate int MyDelegate();   

public class MyClass 
{
    public int InstanceMethod () 
    {
        Console.WriteLine("A message from the instance method."); 
        return 0;
    }
    
    static public int StaticMethod () 
    {
        Console.WriteLine("A message from the static method.");
        return 0;
    }
}

public class MainClass 
{
    static public void Main () 
    {
        MyClass p = new MyClass();
        MyDelegate d = new MyDelegate(p.InstanceMethod);
        d();
        d = new MyDelegate(MyClass.StaticMethod);
        d();
        Console.ReadLine();
    }
}
