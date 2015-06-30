// array out / ref test

using System;
class TestOut
{
    static public void FillArray(out int[] myArray)
    {
        myArray = new int[5] { 1, 2, 3, 4, 5 };
    }

    public static void FillArray1(ref int[] arr)
    {
        if (arr == null)
            arr = new int[10];
        arr[0] = 123;
        arr[4] = 1024;
        //arr[5] = 999; // error
    }
    static public void Main()
    {
        int[] myArray; //不需要进行初始化
        FillArray(out myArray);
        Console.WriteLine("Array elements are:");
        for (int i = 0; i < myArray.Length; i++)
            Console.WriteLine(myArray[i]);

        int[] myArray1 = { 1, 2, 3, 4, 5 };
        FillArray1(ref myArray1);
        Console.WriteLine("Array elements are:");
        for (int i = 0; i < myArray1.Length; i++)
            Console.WriteLine(myArray1[i]);

        Console.ReadLine();
    }
}
