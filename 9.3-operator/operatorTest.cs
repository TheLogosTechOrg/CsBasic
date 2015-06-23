// operator test

using System;
class Fraction
{
    int num, den;
    public Fraction(int num, int den)
    {
        this.num = num;
        this.den = den;
    }

    //重载操作符+
    public static Fraction operator +(Fraction a, Fraction b)
    {
        return new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);
    }

    //重载操作符*
    public static Fraction operator *(Fraction a, Fraction b)
    {
        return new Fraction(a.num * b.num, a.den * b.den);
    }

    //定义操作符double
    public static implicit operator double(Fraction f)
    {
        return (double)f.num / f.den;
    }

    public override string ToString()
    {
        return num + "/" +den;
    }
}

class Test
{
    public static void Main()
    {
        Fraction a = new Fraction(1, 2);
        Fraction b = new Fraction(3, 7);
        Fraction c = new Fraction(2, 3);
        Console.WriteLine(a + "\n" + b + "\n" + c + "\n");
        Fraction result = a * b + c;
        Console.WriteLine(result.ToString());
        Console.WriteLine(result); // implicit conversion will occur here
        Console.WriteLine((double)result);
        Console.ReadLine();
    }
}
