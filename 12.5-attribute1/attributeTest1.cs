// another attribute test

using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

//
//IsTested类是用户定义的特性类。
//
//可以应用于类型（结构、类、枚举、代表）和
//成员（方法、域、事件、 属性、索引）的声明。
//使用时不带参数。
// 
public class IsTestedAttribute : Attribute
{
    public override string ToString()
    {
        return "Is Tested";
    }
}

//
//AuthorAttribute类是用户定义的特性类。
//
//它只能应用于类和结构的声明。
//
//它带有一个未命名的字符串参数（作者的名称）
//和一个可选的命名参数Version，类型为int。
//
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class AuthorAttribute : Attribute
{
    //
    //这个构造函数指定了特性类的未命名参数。
    //
    public AuthorAttribute(string name)
    {
        this.name = name;
        this.version = 0;
    }

    //
    //这个属性只读（没有set访问器），
    //所以不能用作这个特性的命名参数。
    //
    public string Name
    {
        get
        {
            return name;
        }
    }

    //
    //这个属性可读可写（带有set访问器），
    //所以可以用作这个特性类的命名参数
    //
    public int Version
    {
        get
        {
            return version;
        }
        set
        {
            version = value;
        }
    }

    public override string ToString()
    {
        string value = "Author : " + Name;
        if (version != 0)
        {
            value += " Version : " + Version.ToString();
        }
        return value;
    }

    private string name;
    private int version;
}

//
//这里把用户定义的特性类AuthorAttribute和类Account关联在了一起。
//当创建特性时，未命名的字符串参数传递给了AuthorAttribute的构造函数。
//
[Author("Joe Programmer")]
class Account
{
    //
    //把自定义特性IsTestedAttribute和下面的方法关联在一起。
    //
    [IsTested]
    public void AddOrder(Order orderToAdd)
    {
        orders.Add(orderToAdd);
    }

    private List<Order> orders = new List<Order>();
}

//
//把自定义特性AuthorAttribute和IsTestedAttribute custom attributes 和
//下面的类关联在一起。
//
//注意使用AuthorAttribute的命名参数Version。
//
[Author("Jane Programmer", Version = 2), IsTested()]
class Order
{
    //在这里添加代码
}

class MainClass
{
    private static bool IsMemberTested(MemberInfo member)
    {
        foreach (object attribute in member.GetCustomAttributes())
        {
            if (attribute is IsTestedAttribute)
            {
                return true;
            }
        }
        return false;
    }

    private static void DumpAttributes(MemberInfo member)
    {
        Console.WriteLine("Attributes for : " + member.Name);
        foreach (object attribute in member.GetCustomAttributes())
        {
            Console.WriteLine(attribute);
        }
    }

    public static void Main()
    {
        //
        //显示类Account的特性
        //
        DumpAttributes(typeof(Account));

        //
        //显示测试的成员列表
        //
        foreach (MethodInfo method in (typeof(Account)).GetMethods())
        {
            if (IsMemberTested(method))
            {
                Console.WriteLine("Member {0} is tested!", method.Name);
            }
            else
            {
                Console.WriteLine("Member {0} is NOT tested!", method.Name);
            }
        }
        Console.WriteLine();

        //
        //显示Order类的特性
        //
        DumpAttributes(typeof(Order));

        //
        //显示Order类中方法的特性
        //
        foreach (MethodInfo method in (typeof(Order)).GetMethods())
        {
            if (IsMemberTested(method))
            {
                Console.WriteLine("Member {0} is tested!", method.Name);
            }
            else
            {
                Console.WriteLine("Member {0} is NOT tested!", method.Name);
            }
        }

        Console.ReadLine();
    }
}
