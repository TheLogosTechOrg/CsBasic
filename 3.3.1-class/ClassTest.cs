// class test
// ÀàµÄÊ¾Àı

using System;

public class Kid 
{
    private int age;
    private string name;
    
    public Kid() 
    {
        name = "N/A";
    }
    
    public Kid(string name, int age) 
    {
        this.name = name;
        this.age = age;
    }
    
    public void PrintKid() 
    {
        Console.WriteLine("{0}, {1} years old.", name, age);
    }
}

public class MainClass 
{
    public static void Main() 
    {
        Kid kid1 = new Kid("Craig", 11);
        Kid kid2 = new Kid("Sally", 10);
        Kid kid3 = new Kid(); 

        Console.Write("Kid #1: ");
        kid1.PrintKid();
        Console.Write("Kid #2: ");
        kid2.PrintKid();
        Console.Write("Kid #3: ");
        kid3.PrintKid();
        Console.ReadLine();
    }
}
