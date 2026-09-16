namespace _11_LinqDemo;

internal static class QueryableDemo
{
    internal static void Run()
    {
        var students = new List<Student>
        {
            new Student { Name = "Yugansh", Course = "MCA", Marks = 78 },
            new Student { Name = "Suyash", Course = "BCA", Marks = 65 },
            new Student { Name = "Suraj", Course = "MCA", Marks = 72 },
            new Student { Name = "Zoya", Course = "BCA", Marks = 88 }
        };

        // Converts the in-memory collection into IQueryable<Student>
        IQueryable<Student> queryableStudents = students.AsQueryable();

        // Query is being described here
        var query = queryableStudents.Where(student => student.Marks > 70);

        // Query is executed when we enumerate it
        foreach (var student in query)
        {
            Console.WriteLine($"{student.Name} | {student.Marks}");
        }
    }
}