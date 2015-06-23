// explicit / implicit conversion test

using System;
struct Digit
{
    public byte value;
    public Digit(byte value)
    {
        if (value < 0 || value > 9) throw new ArgumentException();
        this.value = value;
    }

    // explicit conversion from byte to Digit
    // 定义显式的byte到Digit转换操作符
    public static explicit operator Digit(byte b)
    {
        Console.WriteLine("explicit conversion occurred");
        return new Digit(b);
    }

    // implicit conversion from Digit to byte
    //定义隐式的Digit到byte的转换操作符
    public static implicit operator byte(Digit d)
    {
        Console.WriteLine("implicit conversion occurred");
        return d.value;
    }
}

class Test
{
    public static void Main()
    {
        byte b = 3;
        Digit d = (Digit)b; //显式转换
        Console.WriteLine(d.value);

        Console.WriteLine();

        try
        {
            byte b1 = 10;
            Digit d1 = (Digit)b1;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        Console.WriteLine();

        Digit d2 = new Digit(3);
        byte b2 = d2; // 从Digit到byte的隐式（不使用强制）转换
        Console.WriteLine(b2);

        Console.ReadLine();
    }
}
