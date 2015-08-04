// thread test

using System;
using System.Threading;

public class ThreadOneWork
{
    private void DoWork()
    {
        for (int i = 0; i < 50000; i++)
        {
            for (int j = 0; j < 10000; j++)
            {
                int y = i + j;
            }
        }
    }

    public void ThreadWork()
    {
        while (true)
        {
            DoWork();
            Console.WriteLine("This message is from Thread One!");
        }
    }
}

public class ThreadTwoWork
{
    private static void DoWork()
    {
        for (int i = 0; i < 50000; i++)
        {
            for (int j = 0; j < 10000; j++)
            {
                int y = i - j;
            }
        }
    }

    public static void ThreadWork()
    {
        while (true)
        {
            DoWork();
            Console.WriteLine("This message is from Thread Two!");
        }
    }
}

public class MainThreadWork
{
    public static void Main(String[] args)
    {
        Thread FirstThread = null;
        Thread SecondThread = null;

        Console.WriteLine("Main thread starts running!");
        Console.WriteLine("Press \'q\' to exit this program!");
        Console.WriteLine("Press \'1\' to switch Thread One state!");
        Console.WriteLine("Press \'2\' to switch Thread Two state!\n");

        try
        {
            FirstThread = new Thread(new ThreadStart(new ThreadOneWork().ThreadWork));
            FirstThread.Priority = ThreadPriority.Normal;

            SecondThread = new Thread(new ThreadStart(ThreadTwoWork.ThreadWork));
            SecondThread.Priority = ThreadPriority.Normal;

            FirstThread.Start();
            SecondThread.Start();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

        while (true)
        {
            Console.WriteLine("This message is from Main Thread!");

            int ch = Console.Read();

            if (ch == 'q')
            {
                break;
            }
            else if (ch == '1')
            {
                if (FirstThread != null)
                {
                    if (FirstThread.ThreadState == ThreadState.Running)
                    {
                        Console.WriteLine("Suspend Thread One!");
                        FirstThread.Suspend();
                    }
                    else if (FirstThread.ThreadState == ThreadState.Suspended)
                    {
                        Console.WriteLine("Resume Thread One!");
                        FirstThread.Resume();
                    }
                }
            }
            else if (ch == '2')
            {
                if (SecondThread != null)
                {
                    if (SecondThread.ThreadState == ThreadState.Running)
                    {
                        Console.WriteLine("Suspend Thread Two!");
                        SecondThread.Suspend();
                    }
                    else if (SecondThread.ThreadState == ThreadState.Suspended)
                    {
                        Console.WriteLine("Resume Thread Two!");
                        SecondThread.Resume();
                    }
                }
            }
        };

        Console.WriteLine("Aborting Thread One...");
        if (FirstThread != null && FirstThread.IsAlive)
        {
            FirstThread.Abort();
            FirstThread = null;
        }

        Console.WriteLine("Aborting Thread Two...");
        if (SecondThread != null && SecondThread.IsAlive)
        {
            SecondThread.Abort();
            SecondThread = null;
        }
    }
}
