// IEnumerable test

using System;
using System.Collections;

//声明enumerator，实现IEnumerator接口：
public class MyEnumerator : IEnumerator
{
    int nIndex;
    MyCollection collection;
    public MyEnumerator(MyCollection coll)
    {
        collection = coll;
        nIndex = -1;
    }

    public void Reset()
    {
        nIndex = -1;
    }

    public bool MoveNext()
    {
        nIndex++;
        return (nIndex < collection.items.GetLength(0));
    }

    public int Current
    {
        get
        {
            return (collection.items[nIndex]);
        }
    }

    //IEnumerator接口上的当前属性：
    object IEnumerator.Current
    {
        get
        {
            return (Current);
        }
    }
}

//声明集合，实现IEnumerable接口：
public class MyCollection : IEnumerable
{
    public int[] items;
    public MyCollection()
    {
        items = new int[5] { 12, 44, 33, 2, 50 };
    }

    public MyEnumerator GetEnumerator()
    {
        return new MyEnumerator(this);
    }

    //实现GetEnumerator()方法：
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        MyCollection col = new MyCollection();
        Console.WriteLine("Values in the collection are:");
        foreach (int i in col)
        {
            Console.WriteLine(i);
        }
        Console.ReadLine();
    }
}
