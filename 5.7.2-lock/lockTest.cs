// lock test

using System;
using System.Threading;

internal class Account
{
    static int counter = 0;
    static int balance;
    Random r = new Random();

    internal Account(int initial)
    {
        balance = initial;
    }

    internal int Withdraw(int amount)
    {
        int actual = amount;

        if (balance < 0) // this will never happen with lock
        {
            throw new Exception("Negative Balance");
        }

        lock (this) // NTOE: comment out this line to watch the exception being thrown
        {
            if (balance >= amount)
            {
                Thread.Sleep(5);
                balance = balance - amount;
            }
            else
            {
                actual = 0; //拒绝处理
            }
            //Console.WriteLine(counter++ + ": withdrawing " + amount + "; actual: " + actual + "; balance: " + balance); // the counter will appear in order
        }
        Console.WriteLine(counter++ + ": withdrawing " + amount + "; actual: " + actual + "; balance: " + balance); // NOTE: the counter will appear in disorder, indicating a racing condition has occured
        return actual;
    }

    internal void DoTransactions()
    {
        for (int i = 0; i < 10; i++)
        {
            Withdraw(r.Next(-50, 100));
        }
    }
}

internal class Test
{
    static internal Thread[] threads = new Thread[10];

    public static void Main()
    {
        Account acc = new Account(0);

        for (int i = 0; i < 10; i++)
        {
            Thread t = new Thread(new ThreadStart(acc.DoTransactions));
            threads[i] = t;
        }

        for (int i = 0; i < 10; i++)
        {
            threads[i].Start();
        }

        Console.ReadLine();
    }
}
