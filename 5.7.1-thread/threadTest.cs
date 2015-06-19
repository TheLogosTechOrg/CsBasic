// thread test

using System;
using System.Threading;

class ThreadTest
{
    public void runme()
    {
        Console.WriteLine("runme called out of main thread");
    }

    public static void Main()
    {
        ThreadTest b = new ThreadTest();
        Thread t = new Thread(new ThreadStart(b.runme));
        t.Start();
        Console.WriteLine("main thread");
        Console.ReadLine();
    }
}
