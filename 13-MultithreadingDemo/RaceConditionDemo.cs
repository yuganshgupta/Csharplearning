using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;

namespace _13_MultithreadingDemo;

internal static class RaceConditionDemo
{
    private static int counter = 0;
    //private static readonly object counterLock = new object();

    internal static void Run()
    {
        Thread t1 = new Thread(IncreaseCounter);
        Thread t2 = new Thread(IncreaseCounter);
        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();
        Console.WriteLine(counter);
        
    }

    private static void IncreaseCounter()
    {   
        for (int i = 0; i < 1000000; i++)
        {
            //lock (counterLock) lock method of preventing race condition
            //{                  useful when we have multiple conditions that need to be executed
            //    counter++;    when those steps depend on each other so you usually protect the whole sequence
            //}
            Interlocked.Increment(ref counter); //It is ideal for things
                                                //like:Increment, decrement, exchange a value
                                                //, and perform compare-and-swap style updates.

        }

        //Console.WriteLine(counter);
    }
}