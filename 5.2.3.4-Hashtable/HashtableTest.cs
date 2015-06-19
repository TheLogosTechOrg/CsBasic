// Hashtable test
//使用Hashtable集合类

using System;
using System.Collections;
public class MainClass
{
    public static void Main(string[] args)
    {
        //声明Hashtable对象：
        Hashtable ziphash = new Hashtable();

        //使用Add()方法添加项目：
        ziphash.Add("98008", "Bellevue");
        ziphash.Add("98052", "Redmond");
        ziphash.Add("98201", "Everett");
        ziphash.Add("98101", "Seattle");
        ziphash.Add("98371", "Puyallup");

        //显示内容：
        Console.WriteLine("Zip code\tCity");
        foreach (string zip in ziphash.Keys)
        {
            Console.WriteLine(zip + "\t\t" + ziphash[zip]);
        }
        Console.ReadLine();
    }
}
