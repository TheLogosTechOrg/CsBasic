// delegate test
// ͨ��������þ�̬��ʵ������

using System;

// do something and get an int
delegate int MyDelegate();   

public class MyClass 
{
    public int InstanceMethod() 
    {
        Console.WriteLine("A message from the instance method."); 
        return 0;
    }
    
    static public int StaticMethod() 
    {
        Console.WriteLine("A message from the static method.");
        return 0;
    }
}

public class MainClass 
{
    static public void Main() 
    {
        MyClass c = new MyClass();
        MyDelegate d = new MyDelegate(c.InstanceMethod);
        d();
        d = new MyDelegate(MyClass.StaticMethod);
        d();
        Console.ReadLine();
    }
}
