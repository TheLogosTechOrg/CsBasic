// array of array test
//数组的数组

using System;
public class ArrayTest
{
    public static void Main()
    {
        int[][] myArray = new int[2][];
        myArray[0] = new int[5] { 1, 3, 5, 7, 9 };
        myArray[1] = new int[4] { 2, 4, 6, 8 };
        Console.WriteLine("The rank of array is: " + myArray.Rank);
        Console.WriteLine("The length of array is: " + myArray.Length);
        for (int i = 0; i < 2; i++)
        {
            Console.Write("Element({0}): ", i);

            for (int j = 0; j < myArray[i].Length; j++)
                Console.Write("{0} ", myArray[i][j]);

            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
