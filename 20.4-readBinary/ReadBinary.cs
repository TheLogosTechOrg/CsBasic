// test reading a file as binary, i.e. byte by byte

using System;
using System.IO;

class ReadBinary
{
    public static void Main(string[] args)
    {
        FileInfo fl = new FileInfo(@"..\..\ReadBinary.txt");
        Stream strm = fl.OpenRead();
        int iNext;
        do
        {
           iNext = strm.ReadByte();
           if (iNext != -1)
              Console.WriteLine(iNext.ToString());
        }
        while (iNext != -1);
        strm.Close();
        Console.WriteLine("All done.");
        Console.ReadLine();
    }
}
