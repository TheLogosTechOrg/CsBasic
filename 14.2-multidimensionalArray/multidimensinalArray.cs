// multidimensional array test
//二维数组

using System;
public class ArrayClass
{
    static void PrintArray(int[,] w)
    {
        Console.WriteLine("The rank of array is: " + w.Rank);
        Console.WriteLine("The length of array is: " + w.Length);
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 2; j++)
                Console.WriteLine("Element({0},{1})={2}", i, j, w[i, j]);
    }

    public static void Main()
    {
        PrintArray(new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } });
        Console.ReadLine();
    }
}
