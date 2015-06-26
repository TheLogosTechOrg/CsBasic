// base test
//访问基类中的成员

using System;
public class Person
{
    protected string ssn = "444-55-6666";
    protected string name = "John L. Malgraine";

    public virtual void GetInfo()
    {
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("SSN: {0}", ssn);
    }
}
class Employee : Person
{
    public string id = "ABC567EFG";

    public override void GetInfo()
    {
        //调用基类中得GetInfo方法
        base.GetInfo();
        Console.WriteLine("Employee ID: {0}", id);
    }
}

public class MyBase
{
   int num;
   public MyBase() 
   {
      Console.WriteLine("in MyBase()");
   }
   public MyBase(int i)
   {
      num = i;
      Console.WriteLine("in MyBase(int i)");
   }
   public int GetNum()
   {
      return num;
   }
}

public class MyDerived : MyBase
{
    static int i = 32;
    public MyDerived(int ii) : base() { }
    public MyDerived() : base(i) { }
}

class TestClass
{
    public static void Main()
    {
        Employee E = new Employee();
        E.GetInfo();

        MyDerived md = new MyDerived();
        MyDerived md1 = new MyDerived(1);

        Console.ReadLine();
    }
}
