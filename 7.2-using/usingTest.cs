// using test

using System;
using MyAlias = MyCompany.Proj.Nested;
using AliasToMyClass = NameSpace1.MyClass;   //使用类的别名

namespace MyCompany.Proj
{
    public class MyClass
    {
        public static void DoNothing()
        {
        }
    }

    namespace Nested   //嵌套名字空间
    {
        public class ClassInNestedNameSpace
        {
            public static void SayHello()
            {
                System.Console.WriteLine("Hello");
            }
        }
    }
}

namespace NameSpace1
{
    public class MyClass
    {
        public override string ToString()
        {
            return "You are in NameSpace1.MyClass";
        }
    }
}

namespace NameSpace2
{
    class MyClass
    {
        public override string ToString()
        {
            return "You are in NameSpace2.MyClass";
        }
    }
}

namespace NameSpace3 
{
    //using NameSpace1;   //using指令
    using NameSpace2;   //using指令

    public class UnNestedClass
    {
        public static void Main()
        {
            MyAlias.ClassInNestedNameSpace.SayHello();   //使用别名

            MyClass mc = new MyClass();
            Console.WriteLine(mc);

            AliasToMyClass somevar = new AliasToMyClass();
            Console.WriteLine(somevar);
            Console.ReadLine();
        }
    }
}
