// test file operations: delete, copy

using System;
using System.IO;

class CopyDelte
{
    public static void Main(string[] args)
    {
        FileInfo file = new FileInfo(@"..\..\CopyDelete.cs");
        string fullPath =file.FullName;
        DirectoryInfo dir = new DirectoryInfo(@"..\..\");
        dir.CreateSubdirectory("backup");
        DirectoryInfo backupDir = new DirectoryInfo(@"..\..\backup");
        foreach (FileInfo subfile in backupDir.GetFiles())
        {
            subfile.Delete();
        }
        file.CopyTo(@"..\..\backup\CopyDelete_Backup.cs");

        DirectoryInfo tempDir = new DirectoryInfo(@"..\..\temp");
        tempDir.Create();
        FileInfo tempFile = new FileInfo(@"..\..\temp\temp.txt");
        FileStream fs = tempFile.Create();

        fs.Close();
        tempFile.Delete();
        tempDir.Delete(true);

        Console.ReadLine();
    }
}
