// goto test

//嵌套搜索循环
using System;
using System.IO;

public class GotoTest1
{
    public static void Main()
    {
        int x = 200, y = 4;
        int[,] myArray = new int[x, y];
        int n = 0;

        //初始化数组：
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                n++;
                myArray[i, j] = n;
                Console.Write(n);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        //读取输入：
        Console.Write("Enter the number to search for: ");

        //输入一个字符
        string s = Console.ReadLine();
        int myNumber = Int32.Parse(s);

        //搜索：
        int r = -1, c = -1;
        for (int i = 0; i < x; i++)
            for (int j = 0; j < y; j++)
                if (myArray[i, j] == myNumber)
                {
                    r = i; 
                    c = j;
                    goto Found;
                }

        Console.WriteLine("The number {0} was not found.", myNumber, r, c);
        goto Finish;

    Found:
        Console.WriteLine("The number {0} is found at row {1} and column {2}.", myNumber, r, c);
        // NOTE: the program will continue to label Finish. 
    Finish:
        Console.WriteLine("End of search.");
        Console.ReadLine();

        //
        //
        // another example
        x = 55;
        Console.WriteLine("x = {0}", x);

        if (x == 55)
        {
            x = 135;
            goto A;
        }

        x = x + 1;

        A:
        for (int i = 1; i <= 5; i++)
        {
        // A: Console.WriteLine(i); // error: A is not reachable 
            Console.WriteLine(i);
        }

        Console.WriteLine("x = {0}", x);
        Console.ReadLine();
    }
}
