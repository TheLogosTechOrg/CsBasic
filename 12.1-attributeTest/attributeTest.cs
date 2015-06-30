// attribute test

using System;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
public class Author : Attribute
{
    private string name;
    public double version;

    public Author(string name)
    {
        this.name = name; version = 1.0;
    }

    public string GetName()
    {
        return name;
    }
}

[AttributeUsage(AttributeTargets.All)]
public class HelpAttribute : System.Attribute
{
    public readonly string Url;
    private string topic;
    public string Topic               //Topic是命名参数
    {
        get
        {
            return topic;
        }
        set
        {
            topic = value;
        }
    }

    public HelpAttribute(string url)   //url是位置参数
    {
        this.Url = url;
    }
}



[Author("H. Ackerman")]
class FirstClass
{
    /*...*/
}

class SecondClass  // no Author attribute
{
    /*...*/
}

[Author("H. Ackerman"), Author("M. Knott", version = 1.1)]
class Steerage
{
    /*...*/
}

[HelpAttribute("http://thelogostech.com")]
class MyClass
{
}



class AuthorInfo
{
    public static void Main()
    {
        PrintAuthorInfo(typeof(FirstClass));
        PrintAuthorInfo(typeof(SecondClass));
        PrintAuthorInfo(typeof(Steerage));

        System.Reflection.MemberInfo info = typeof(MyClass);
        object[] attributes = info.GetCustomAttributes(true); // a slightly different way to get the attributes list
        for (int i = 0; i < attributes.Length; i++)
        {
            System.Console.WriteLine(attributes[i]);
            if (attributes[i] is HelpAttribute)
                System.Console.WriteLine((attributes[i] as HelpAttribute).Url);
        }

        Console.ReadLine();
    }
    public static void PrintAuthorInfo(Type t)
    {
        Console.WriteLine("Author information for {0}", t);
        Attribute[] attrs = Attribute.GetCustomAttributes(t);
        foreach (Attribute attr in attrs)
        {
            if (attr is Author)
            {
                Author a = (Author)attr;
                Console.WriteLine("   {0}, version {1:f}", a.GetName(), a.version);
            }
        }
    }
}
