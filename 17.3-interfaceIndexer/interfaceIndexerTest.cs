// interface indexer test
//接口上的索引

using System;
public interface IMyInterface
{
    int this[int index]
    {
        get;
        set;
    }
}

class IndexerClass : IMyInterface
{
    private int[] myArray = new int[100];
    public int this[int index]
    {
        get
        {
            if (index < 0 || index >= 100)
                return 0;
            else
                return myArray[index];
        }
        set
        {
            if (!(index < 0 || index >= 100))
                myArray[index] = value;
        }
    }
}

public class MainClass
{
    public static void Main()
    {
        IndexerClass b = new IndexerClass();
        b[2] = 4;
        b[5] = 32;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Element #{0} = {1}", i, b[i]);
        }
        Console.ReadLine();
    }
}
