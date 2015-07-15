// property test
//属性

using System;
public class Employee
{
    public static int numberOfEmployees;
    private static int counter;
    private string name;

    //可读写实例属性:
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    //只读静态属性:
    public static int Counter
    {
        get
        {
            return counter;
        }
    }

    //构造函数:
    public Employee()
    {
        counter = ++numberOfEmployees;
    }
}

class Person
{
    private string myName = "N/A";
    private int myAge = 0;
    public string Name
    {
        get
        {
            return myName;
        }
        set
        {
            myName = value;
        }
    }
    public int Age
    {
        get
        {
            return myAge;
        }
        set
        {
            myAge = value;
        }
    }
    public override string ToString()
    {
        return "Name = " + Name + ", Age = " + Age;
    }
}

public class MainClass
{
    public static void Main()
    {
        Employee.numberOfEmployees = 100;
        Employee e1 = new Employee();
        e1.Name = "Claude Vige";
        Console.WriteLine("Employee number: {0}", Employee.Counter);
        Console.WriteLine("Employee name: {0}", e1.Name);

        Employee e2 = new Employee();
        e2.Name = "Claude2 Vige";
        Console.WriteLine("Employee number: {0}", Employee.Counter);
        Console.WriteLine("Employee name: {0}", e2.Name);

        Person person = new Person();
        Console.WriteLine("Person details - {0}", person);
        person.Name = "Joe";
        person.Age = 99;
        Console.WriteLine("Person details - {0}", person);
        person.Age += 1;
        Console.WriteLine("Person details - {0}", person);

        Console.ReadLine();
    }
}
