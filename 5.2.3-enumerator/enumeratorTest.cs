// enumerator test

using System;

//声明enumerator类：
public class MyEnumerator
{
    int nIndex;
    MyCollection collection;
    public MyEnumerator(MyCollection coll)
    {
        collection = coll;
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
}

//声明集合：
public class MyCollection
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
}

public class MainClass
{
    public static void Main()
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
