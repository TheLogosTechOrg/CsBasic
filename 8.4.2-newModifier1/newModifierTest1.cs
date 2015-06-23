// new as a modifer for a class
//对嵌套类型使用new 修饰符

using System;
public class MyBaseC
{
    public class MyClass
    {
        public int x = 200;
        public int y;
    }
}

public class MyDerivedC : MyBaseC
{
    new public class MyClass   //嵌套的类型隐藏了基类中的类型成员
    {
        public int x = 100;
        public int y;
        public int z;
    }

    public static void Main()
    {
        //由覆盖的类创建对象
        MyClass S1 = new MyClass();

        // Creating object from the hidden class:
        MyBaseC.MyClass S2 = new MyBaseC.MyClass();

        Console.WriteLine(S1.x);
        Console.WriteLine(S2.x);
        Console.ReadLine();
    }
}
