// UNsync test: same as 21.1.3.0, except the Monitor statements are commented out in the increment method

namespace synchronization
{
    using System;
    using System.Threading;

    struct CounterStruct
    {
        // NOTE: the two counters are supposed to be the same all the time, if synced
        private int CounterOne;
        private int CounterTwo;

        public int Counter1
        {
            get
            {
                return CounterOne;
            }
            set
            {
                CounterOne = value;
            }
        }
        public int Counter2
        {
            get
            {
                return CounterTwo;
            }
            set
            {
                CounterTwo = value;
            }
        }
    }

    public class MainClass
    {
        private Thread FirstCounterThread;
        private Thread SecondCounterThread;
        private Thread ThirdCounterThread;
        private Thread WatchThread;

        private int NumberOfUnsync;

        private CounterStruct Counters;

        public static void Main()
        {
            MainClass main = new MainClass();
            main.Init();

            Console.WriteLine("Press \'q\' to exit this program!");
            while (Console.Read() != 'q') ;

            main.KillThreads();
        }

        public void Init()
        {
            NumberOfUnsync = 0;
            Counters = new CounterStruct();
            Counters.Counter1 = 0;
            Counters.Counter2 = 0;

            WatchThread = new Thread(new ThreadStart(WatchCounters));
            FirstCounterThread = new Thread(new ThreadStart(IncrementCounterOne));
            SecondCounterThread = new Thread(new ThreadStart(IncrementCounterOne));
            ThirdCounterThread = new Thread(new ThreadStart(IncrementCounterOne));

            WatchThread.Start();
            FirstCounterThread.Start();
            SecondCounterThread.Start();
            ThirdCounterThread.Start();
        }

        public void KillThreads()
        {
            if (WatchThread.IsAlive)
            {
                WatchThread.Abort();
            }

            if (FirstCounterThread.IsAlive)
            {
                FirstCounterThread.Abort();
            }

            if (SecondCounterThread.IsAlive)
            {
                SecondCounterThread.Abort();
            }

            if (ThirdCounterThread.IsAlive)
            {
                ThirdCounterThread.Abort();
            }
            WatchThread = null;
            FirstCounterThread = null;
            SecondCounterThread = null;
            ThirdCounterThread = null;
        }

        private void IncrementCounterOne()
        {
            while (true)
            {
                //进入临界区
                //Monitor.Enter(this);
                Counters.Counter1++;
                Thread.Sleep(100);
                Counters.Counter2++;
                //Monitor.Exit(this);
                //结束临界区
            }
        }

        private void IncrementCounterTwo()
        {
            while (true)
            {
                //进入临界区
                //Monitor.Enter(this);
                Counters.Counter1++;
                Thread.Sleep(100);
                Counters.Counter2++;
                //Monitor.Exit(this);
                //结束临界区
            }
        }

        private void IncrementCounterThree()
        {
            while (true)
            {
                //进入临界区
                //Monitor.Enter(this);
                Counters.Counter1++;
                Thread.Sleep(100);
                Counters.Counter2++;
                //Monitor.Exit(this);
                //结束临界区
            }
        }

        private void WatchCounters()
        {
            while (true)
            {
                //进入临界区
                Monitor.Enter(this);
                Thread.Sleep(200);
                Console.Write("counter1：" + Counters.Counter1 + " counter2: " + Counters.Counter2);
                //如果两个值不相等，显示不同步消息
                if (Counters.Counter1 != Counters.Counter2)
                {
                    NumberOfUnsync++;
                    Console.WriteLine(" Out of synchronization: " + NumberOfUnsync.ToString());
                }
                else
                    Console.WriteLine(" Still synced");
                Monitor.Exit(this);
                //结束临界区
            }
        }
    }
}

