// process test

using System;
using System.Diagnostics;
using System.Threading;

public class ProcessInfo
{
    public static void Main(String[] args)
    {
        //var cmdLineArgs = Environment.GetCommandLineArgs();
        //string appName = cmdLineArgs[0];

        //if (args.Length != 2 && (args.Length != 1 || args[0] != "e"))
        //{
        //    Console.WriteLine("Usage: ");
        //    Console.WriteLine("\t" + appName + " e: Enumerate processes");
        //    Console.WriteLine("\t" + appName + " <command> <process_id>");
        //    Console.WriteLine("");
        //    Console.WriteLine("\t\t<command> =");
        //    Console.WriteLine("\t\t\ti: Show process info");
        //    Console.WriteLine("\t\t\tc: Close");
        //    Console.WriteLine("\t\t\tk: Kill");
        //    Console.WriteLine("\t\t\tp: Show process priority");
        //    Console.ReadLine();
        //    return;
        //}

        //string command = args[0];

        Console.Write("Enter command: ");
        string command = Console.ReadLine().Substring(0,1);

        if (command == "e")
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                Console.WriteLine(process.Id + "\t: " + process.ProcessName);
            }
        }
        else
        {
            //Int32 processid = Int32.Parse(args[1]);

            Console.Write("Enter process id: ");
            int processid = int.Parse(Console.ReadLine());

            Process process = Process.GetProcessById(processid);
            switch (command)
            {
                case "c":
                    process.CloseMainWindow();
                    break;

                case "k":
                    process.Kill();
                    break;

                case "p":
                    Console.WriteLine("Priority: " + process.PriorityClass.ToString());
                    break;

                case "i":
                    Console.WriteLine("Priority Class         :{0}", process.PriorityClass.ToString());
                    Console.WriteLine("Handle Count           :{0}", process.HandleCount);
                    Console.WriteLine("Main Window Title      :{0}", process.MainWindowTitle);
                    Console.WriteLine("Min Working Set        :{0}", process.MinWorkingSet);
                    Console.WriteLine("Max Working Set        :{0}", process.MaxWorkingSet);
                    Console.WriteLine("Paged Memory Size      :{0}", process.PagedMemorySize);
                    Console.WriteLine("Peak Paged Memory Size :{0}", process.PeakPagedMemorySize);
                    break;
            }
        }

        Console.ReadLine();

        // start the windows notepad, and close it after 10 sec
        string executableFilename = "notepad.exe";
        Process process1 = new Process();
        process1.StartInfo.FileName = executableFilename;
        process1.Start();
        process1.WaitForInputIdle();
        Thread.Sleep(10000);
        if (!process1.CloseMainWindow())
        {
            process1.Kill();
        }

    }
}
