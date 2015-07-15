// interface property test
//接口属性

using System;
interface IEmployee
{
    string Name
    {
        get;
        set;
    }

    int Counter
    {
        get;
    }
}

public class Employee : IEmployee
{
    public static int numberOfEmployees;
    private int counter;
    private string name;
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
    public int Counter
    {
        get
        {
            return counter;
        }
    }
    public Employee()
    {
        counter = ++numberOfEmployees;
    }
}

public class MainClass
{
    public static void Main()
    {
        Console.Write("Enter number of employees: ");
        string s = Console.ReadLine();
        Employee.numberOfEmployees = int.Parse(s);
        Employee e1 = new Employee();
        Console.Write("Enter the name of the new employee: ");
        e1.Name = Console.ReadLine();
        Console.WriteLine("The employee information:");
        Console.WriteLine("Employee number: {0}", e1.Counter);
        Console.WriteLine("Employee name: {0}", e1.Name);
        Console.ReadLine();
    }
}
