using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _13_MultithreadingDemo;

internal class ThreadLifecycleDemo
{
    internal static void Run()
    {
        Thread w1 = new Thread(worker);
        //w1.IsBackground = true;
        Console.WriteLine(w1.IsAlive);
        w1.Start();
        Console.WriteLine(w1.IsAlive);
        w1.Join();
        Console.WriteLine(w1.IsAlive);
        Console.WriteLine("Main is finishing");
    }

    static void worker()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Worker 1");
            Thread.Sleep(500);
            Console.WriteLine("Worker 2");
        }
    }

}
