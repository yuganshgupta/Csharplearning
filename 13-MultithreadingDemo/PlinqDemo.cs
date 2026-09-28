namespace _13_MultithreadingDemo;

internal static class PlinqDemo
{
    internal static void Run()
    {
        int[] numbers = Enumerable.Range(1, 10).ToArray();

        var result = numbers
            .AsParallel()
            .Where(n =>
            {
                Console.WriteLine(
                    $"Processing {n} | Thread {Environment.CurrentManagedThreadId}"
                );

                return n % 2 == 0;
            })
            .Select(n => n * n)
            .ToList();

        Console.WriteLine("Results:");

        foreach (int number in result)
        {
            Console.WriteLine(number);
        }
    }
}