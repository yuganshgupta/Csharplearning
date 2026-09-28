    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading;
    
    namespace _13_MultithreadingDemo;

    internal static class SemaphoreDemo
    {
        private static readonly SemaphoreSlim semaphore = new(2);

        internal static void Run()
        {
            for (int i = 1; i <= 5; i++)
            {
                int job = i;

                ThreadPool.QueueUserWorkItem(_ => DoWork(job));
            }

            Thread.Sleep(3000);
        }

        private static void DoWork(int job)
        {
            semaphore.Wait();

            try
            {
                Console.WriteLine($"Job {job} entered | Thread {Environment.CurrentManagedThreadId}");
                Thread.Sleep(1000);
                Console.WriteLine($"Job {job} leaving");
            }
            finally
            {
                semaphore.Release();
            }
        }
    }