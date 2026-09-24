using System.Threading;

namespace _13_MultithreadingDemo;

internal class DeadlockDemo
{
    private static readonly object lockA = new object();
    private static readonly object lockB = new object();

    internal static void Run()
    {
        Thread t1 = new Thread(m1);
        Thread t2 = new Thread(m2);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();
    }

    static void m1()
    {
        lock (lockA)
        {
            Console.WriteLine("m1 acquired A");

            Thread.Sleep(50);

            lock (lockB)
            {
                Console.WriteLine("m1 acquired B");
            }
        }
    }

    static void m2()
    {
        lock (lockA)
        {
            Console.WriteLine("m2 acquired A");

            Thread.Sleep(50);

            lock (lockB)
            {
                Console.WriteLine("m2 acquired B");
            }
        }
    }
}