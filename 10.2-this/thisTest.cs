// this test

using System;
public class Employee
{
    public string name;
    public string alias;
    public decimal salary = 3000.00m;

    //构造函数
    public Employee(string name, string alias)
    {
        //使用this来限定域：name和alias
        this.name = name;
        this.alias = alias;
    }

    //打印方法
    public void printEmployee()
    {
        Console.WriteLine("Name: {0}\nAlias: {1}", name, alias);
        //使用把对象传递给CalcTax方法
        Console.WriteLine("Taxes: {0:C}", Tax.CalcTax(this));
    }
}
public class Tax
{
    public static decimal CalcTax(Employee E)
    {
        return (0.08m * (E.salary));
    }
}

public class MainClass
{
    public static void Main()
    {
        Employee E1 = new Employee("John M. Trainer", "jtrainer");
        E1.printEmployee();
        Console.ReadLine();
    }
}
