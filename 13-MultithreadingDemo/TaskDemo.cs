namespace _13_MultithreadingDemo;

internal static class TaskDemo
{
    internal static void Run()
    {
        Console.WriteLine(
            $"Main thread: {Environment.CurrentManagedThreadId}"
        );

        Task task = Task.Run(() =>
        {
            Console.WriteLine(
                $"Task running on thread: {Environment.CurrentManagedThreadId}"
            );

            Thread.Sleep(500);
        });

        Console.WriteLine("Main continues.");

        task.Wait();

        Console.WriteLine("Task completed.");
    }
}