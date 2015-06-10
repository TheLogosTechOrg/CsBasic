// test writing a file as binary, i.e. byte by byte

using System;
using System.IO;

class WriteBinary
{
    public static void Main(string[] args)
    {
        byte [] bytes = {70,71,72,73,74,75,13,10};
        FileStream strm = new FileStream(@"..\..\WriteBinary.txt", FileMode.OpenOrCreate, FileAccess.Write);
        foreach (byte bNext in bytes)
        {
            Console.WriteLine(bNext);
            strm.WriteByte(bNext);
        }
        strm.Close();
        Console.WriteLine("All done.");
        Console.ReadLine();
    }
}
