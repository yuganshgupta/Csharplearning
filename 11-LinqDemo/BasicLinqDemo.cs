namespace _11_LinqDemo;

internal static class BasicLinqDemo
{
    internal static void Run()
    {
        List<int> marks = new List<int>
        {
            10, 60, 67, 45, 63, 50, 11, 89, 59, 75
        };

        // Where filters values based on a condition
        var greaterThan50 = marks.Where(mark => mark > 50);

        // Select transforms each value
        var markText = marks.Select(mark => $"Marks : {mark + 5}");

        foreach (var mark in markText)
        {
            Console.WriteLine(mark);
        }

        // LINQ queries like Where and Select use deferred execution
        // unless something like ToList() forces them to execute immediately

        // Sort ascending
        var asc = marks.OrderBy(mark => mark);

        // Sort descending
        var desc = marks.OrderByDescending(mark => mark);
    }
}