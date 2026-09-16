namespace _11_LinqDemo;

internal class Program
{
    static void Main(string[] args)
    {
        BasicLinqDemo.Run();

        Console.WriteLine("\n--- Student LINQ ---");
        StudentLinqDemo.Run();

        Console.WriteLine("\n--- Join LINQ ---");
        JoinDemo.Run();

        Console.WriteLine("\n--- IQueryable demo without EF Core ---");
        QueryableDemo.Run();
    }
}