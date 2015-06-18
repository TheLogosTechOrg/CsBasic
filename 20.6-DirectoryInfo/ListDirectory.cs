// DirectoryInfo test

using System;
using System.IO;

class ListDirectory
{
    public static void Main(string[] args)
    {
        DirectoryInfo fl = new DirectoryInfo("C:\\Windows");
        Console.WriteLine("Connected to folder: " + fl.Name);
        Console.WriteLine("Full path: " + fl.FullName);
        // the following two used to work when C# was in beta
        //Console.WriteLine("Is Directory: " + fl.IsDirectory.ToString());
        //Console.WriteLine("Is File: " + fl.IsFile);
        Console.WriteLine("Is Directory: " + Directory.Exists(fl.FullName));
        Console.WriteLine("Is File: " + File.Exists(fl.FullName));
        Console.WriteLine();

        Console.WriteLine("Files contained in this folder:");
        FileInfo[] childfiles = fl.GetFiles();
        foreach (FileInfo childfile in childfiles)
        {
           Console.WriteLine("  " + childfile.Name);
        }
        Console.WriteLine();

        Console.WriteLine("Subfolders contained in this folder:");
        DirectoryInfo[] childfolders = fl.GetDirectories();
        foreach (DirectoryInfo childfolder in childfolders)
        {
            Console.WriteLine("  " + childfolder.Name);
        }
        Console.ReadLine();
    }
}
