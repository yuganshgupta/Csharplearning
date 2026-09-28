namespace _13_MultithreadingDemo;

internal static class ParallelDemo
{
    internal static void Run()
    {
        Parallel.For(0, 5, i =>
        {
            Console.WriteLine(
                $"Iteration {i} | Thread {Environment.CurrentManagedThreadId}"
            );

            Thread.Sleep(500);
        });

        Console.WriteLine("Parallel.For completed.");
    }
}