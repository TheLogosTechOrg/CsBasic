// another access modifier test

using System;

delegate int MyDelegate();
public class B // this is correct
// class B // this will cause errors
{
    //私有方法：
    int MyPrivateMethod()
    {
        return 0;
    }
}

public class A
{
    //域
    public B myField = new B();
    // Error: The type B is less accessible than the field A.myField

    //常量
    public readonly B myConst = new B();
    // Error: The type B is less accessible than the constant A.myConst

    //方法
    public B MyMethod()
    {
        return new B();
    }
    // Error: The type B is less accessible than the method A.MyMethod

    //属性
    public B MyProp
    {
        set
        {
        }
    }
    // Error: The type B is less accessible than the property A.MyProp

    //代表
    //MyDelegate d = new MyDelegate(B.MyPrivateMethod);
    // Error: The parameter B.MyMethod is not accessible due to protection level

    //操作符
    public static B operator +(A m1, B m2)
    {
        return new B();
        // Error: The type B is less accessible than the operator A.operator +(A,B)
    }

    public static void Main()
    { }
}
