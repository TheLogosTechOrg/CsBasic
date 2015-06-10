// write text file test

using System;
using System.IO;

class WriteText
{
    public static void Main(string[] args)
    {
        StreamWriter strm = new StreamWriter("TextFile.txt", false);
        strm.Write("This is a text file: ");
        strm.WriteLine("TextFile.txt");
        strm.WriteLine("Next lines are numbers");
        strm.WriteLine(3);
        strm.WriteLine(4.55);
        strm.WriteLine("The next line is a boolean");
        strm.WriteLine(true);
        strm.WriteLine("The next line is a class name");
        strm.WriteLine(strm);
        strm.WriteLine("THE END");
        strm.Close();
    }
}
