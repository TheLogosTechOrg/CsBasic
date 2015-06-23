// new test
//new操作符

using System;
class NewTest
{
    struct MyStruct
    {
        public int x;
        public int y;
        public MyStruct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class MyClass
    {
        public string name;
        public int id;

        public MyClass()
        {
        }

        public MyClass(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }

    public static void Main()
    {
        //使用缺省构造函数创建对象：
        MyStruct Location1 = new MyStruct();
        MyClass Employee1 = new MyClass();

        //显示值：
        Console.WriteLine("Default values:");
        Console.WriteLine("\tStruct members: {0}, {1}",
           Location1.x, Location1.y);
        Console.WriteLine("\tClass members: {0}, {1}",
           Employee1.name, Employee1.id);

        //使用带有参数的构造函数创建对象：
        MyStruct Location2 = new MyStruct(10, 20);
        MyClass Employee2 = new MyClass(1234, "John Martin Smith");

        //显示值：
        Console.WriteLine("Assigned values:");
        Console.WriteLine("\tStruct members: {0}, {1}",
           Location2.x, Location2.y);
        Console.WriteLine("\tClass members: {0}, {1}",
           Employee2.name, Employee2.id);

        Console.ReadLine();
    }
}
