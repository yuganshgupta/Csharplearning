    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Collections.Concurrent;

    namespace _13_MultithreadingDemo;

    internal class ConcurrentCollectionsDemo
    {

        internal static void Run()
        {
            ConcurrentDictionary<int, string> users = new();
            using var countdown = new CountdownEvent(5);
        for (int i = 1; i <= 5; i++)
        {
            int id = i;

            ThreadPool.QueueUserWorkItem(_ =>
            {
                users.TryAdd(id, $"User {id}");

                Console.WriteLine(
                    $"Added User {id} | Thread {Environment.CurrentManagedThreadId}"
                );

                countdown.Signal();
            });
            
        }
        countdown.Wait();

        foreach (var user in users)
        {
            Console.WriteLine($"{user.Key} -> {user.Value}");
        }

    }
    }
