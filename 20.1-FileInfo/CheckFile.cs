// FileInfo test

using System;
using System.IO;

class CheckFile
{
    public static void Main(string[] args)
    {
        FileInfo fl = new FileInfo(@"..\..\CheckFile.cs");
        Console.WriteLine("File Name: " + fl.Name);
        Console.WriteLine("Folder Name: " + fl.Directory);
        Console.WriteLine("Full Path: " + fl.FullName);
        // the following two used to work when C# was in beta
        //Console.WriteLine("Is Directory: " + fl.IsDirectory.ToString());
        //Console.WriteLine("Is File: " + fl.IsFile.ToString());
        Console.WriteLine("Last write time: " + fl.LastWriteTime.ToString());
        Console.WriteLine("Size in bytes: " + fl.Length);
        Console.ReadLine();
    }
}
