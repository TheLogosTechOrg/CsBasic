// overload test 1

using System;

public struct DBBool
{
    //三种可能的DBBool值
    public static readonly DBBool dbNull = new DBBool(0);
    public static readonly DBBool dbFalse = new DBBool(-1);
    public static readonly DBBool dbTrue = new DBBool(1);

    //私有域，用来存放-1、0、1，分别对应dbFalse、dbNull、dbTrue
    int value;

    //私有构造函数，value必须是-1、0或1
    DBBool(int value)
    {
        this.value = value;
    }

    //隐式把bool转换成DBBool。把true映射成DBBool.dbTrue
    //把false映射成DBBool.dbFalse
    public static implicit operator DBBool(bool x)
    {
        return x ? dbTrue : dbFalse;
    }

    //显式把DBBool转换成bool。如果给定的DBBool是dbNull，则抛出异常，
    //否则，返回true或false。
    public static explicit operator bool(DBBool x)
    {
        if (x.value == 0) throw new InvalidOperationException();
        return x.value > 0;
    }

    //相等操作符，如果有一个操作数是dbNull，返回dbNull，
    //否则，返回dbTrue或dbFalse。
    public static DBBool operator ==(DBBool x, DBBool y)
    {
        if (x.value == 0 || y.value == 0) return dbNull;
        return x.value == y.value ? dbTrue : dbFalse;
    }

    //不相等操作符，如果有一个操作数是dbNull，返回dbNull，
    //否则，返回dbTrue或dbFalse。
    public static DBBool operator !=(DBBool x, DBBool y)
    {
        if (x.value == 0 || y.value == 0) return dbNull;
        return x.value != y.value ? dbTrue : dbFalse;
    }

    //逻辑非操作符，如果操作数是dbFalse，则返回dbTrue，
    //如果是dbNull，则返回dbNull，
    //如果是dbTrue，则返回dbFalse。
    public static DBBool operator !(DBBool x)
    {
        return new DBBool(-x.value);
    }

    //逻辑AND操作符，如果有一个操作数是dbFalse，则返回fbFalse，
    //如果有一个操作数是dbNull，则返回dbNull，否则返回dbTrue。
    public static DBBool operator &(DBBool x, DBBool y)
    {
        return new DBBool(x.value < y.value ? x.value : y.value);
    }

    //逻辑OR操作符，如果有一个操作数是dbTrue，则返回dbTrue，
    //如果有一个操作数是dbNull，则返回dbNull，否则返回dbFalse。
    public static DBBool operator |(DBBool x, DBBool y)
    {
        return new DBBool(x.value > y.value ? x.value : y.value);
    }

    //true操作符，如果操作数是dbTrue，则返回true，
    //否则返回false。
    public static bool operator true(DBBool x)
    {
        return x.value > 0;
    }

    //false操作符，如果操作数是dbFalse，则返回true，
    //否则返回false。
    public static bool operator false(DBBool x)
    {
        return x.value < 0;
    }

    //重载从DBBool到string的转换
    public static implicit operator string(DBBool x)
    {
        return x.value > 0 ? "dbTrue"
             : x.value < 0 ? "dbFalse"
             : "dbNull";
    }

    //覆盖把DBBool转换成string的ToString方法
    public override string ToString()
    {
        return (string)this;
    }
}

class Test
{
    static void Main()
    {
        DBBool a, b;
        a = DBBool.dbTrue;
        b = DBBool.dbNull;

        Console.WriteLine("!{0} = {1}", a, !a);
        Console.WriteLine("!{0} = {1}", b, !b);
        Console.WriteLine("{0} & {1} = {2}", a, b, a & b);
        Console.WriteLine("{0} | {1} = {2}", a, b, a | b);
        if (b)
            Console.WriteLine("b is definitely true");
        else
            Console.WriteLine("b is not definitely true");

        Console.ReadLine();
    }
}
