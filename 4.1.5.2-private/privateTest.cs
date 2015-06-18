// private member
//私有成员

using System;
class Employee
{
    public string name = "xx";
    double salary = 100.00;   //缺省为私有访问
    public double AccessSalary()
    {
        return salary;
    }
}

class MainClass
{
    public static void Main()
    {
        Employee e = new Employee();

        //访问公开成员：
        string n = e.name;
        Console.WriteLine(n);

        //访问私有成员：
        //double s1 = e.salary; // error
        double s2 = e.AccessSalary();
        Console.WriteLine(s2);

        Console.ReadLine();
    }
}
