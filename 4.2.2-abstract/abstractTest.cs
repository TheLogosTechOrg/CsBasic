// abstract class
//抽象类

using System;

abstract class MyBaseC   //抽象类
{
    protected int x = 100;
    protected int y = 150;

    public abstract void MyMethod();   //抽象方法

    public abstract int GetX   //抽象属性
    {
        get;
    }

    public abstract int GetY   //抽象属性
    {
        get;
    }
}

class MyDerivedC : MyBaseC
{
    public override void MyMethod()
    {
        x++;
        y++;
    }

    public override int GetX   //覆盖属性
    {
        get
        {
            return x + 10;
        }
    }

    public override int GetY   //覆盖属性
    {
        get
        {
            return y + 10;
        }
    }

    public static void Main()
    {
        MyDerivedC mC = new MyDerivedC();
        mC.MyMethod();
        Console.WriteLine("x = {0}, y = {1}", mC.GetX, mC.GetY);
        Console.ReadLine();
    }
}
