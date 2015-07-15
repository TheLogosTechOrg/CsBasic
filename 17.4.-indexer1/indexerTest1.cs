// indexer test 1

using System;
using System.IO;

public class FileByteArray
{
    Stream stream;
    public FileByteArray(string fileName)
    {
        stream = new FileStream(fileName, FileMode.Open);
    }
    public void Close()
    {
        stream.Close();
        stream = null;
    }
    public byte this[long index]
    {
        get
        {
            byte[] buffer = new byte[1];
            stream.Seek(index, SeekOrigin.Begin);
            stream.Read(buffer, 0, 1);
            return buffer[0];
        }
        set
        {
            byte[] buffer = new byte[1] { value };
            stream.Seek(index, SeekOrigin.Begin);
            stream.Write(buffer, 0, 1);
        }
    }
    public long Length
    {
        get
        {
            return stream.Seek(0, SeekOrigin.End);
        }
    }
}

public class Reverse
{
    public static void Main(String[] args)
    {
        string fileName;
#if DEBUG
        fileName = @"C:\temp\Test.txt";
#else
        if (args.Length == 0)
        {
            Console.WriteLine("indexer <filename>");
            return;
        }
        fileName = args[0];
#endif
        FileByteArray file = new FileByteArray(fileName);
        long len = file.Length;

        for (long i = 0; i < len / 2; ++i)
        {
            byte t;
            t = file[i];
            file[i] = file[len - i - 1];
            file[len - i - 1] = t;
        }

        file.Close();
    }
}
