// read text file test

using System;
using System.IO;

class ReadText
{
    public static void Main(string[] args)
    {
        StreamReader reader = File.OpenText(@"..\..\ReadText.cs");
        string str;
        while ((str=reader.ReadLine()) != null) 
        {
            Console.WriteLine (str);
        }
        reader.Close();
        Console.ReadLine();
    }
}
