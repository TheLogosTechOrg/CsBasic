// overload test

using System;

public class Complex
{
    public int real = 0;
    public int imaginary = 0;

    public Complex(int real, int imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
    }

    public static void Main()
    {
        Complex num1 = new Complex(2, 3);
        Complex num2 = new Complex(3, 4);

        Complex sum = num1 + num2;
        //Complex diff = num1 - num2; // error

        Console.WriteLine("Real: {0}", sum.real);
        Console.WriteLine("Imaginary: {0}", sum.imaginary);
        Console.ReadLine();
    }
}
