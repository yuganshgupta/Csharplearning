namespace _11_LinqDemo;

internal static class StudentLinqDemo
{
    internal static void Run()
    {
        var stu = new List<Student>
        {
            new Student { Name = "Yugansh", Course = "MCA", Marks = 78 },
            new Student { Name = "Suyash", Course = "BCA", Marks = 65 },
            new Student { Name = "Suraj", Course = "MCA", Marks = 72 },
            new Student { Name = "Zoya", Course = "BCA", Marks = 88 },
            new Student { Name = "Aman", Course = "MCA", Marks = 69 },
            new Student { Name = "Karan", Course = "BCA", Marks = 81 }
        };

        // First sort by Course
        // Then sort students with the same Course by Name
        var stud = stu
            .OrderBy(student => student.Course)
            .ThenBy(student => student.Name);

        foreach (var student in stud)
        {
            Console.WriteLine($"{student.Course} {student.Name}");
        }

        Console.WriteLine("\nGrouped by Course");

        // Group students into separate groups using Course as the key
        var gstu = stu.GroupBy(student => student.Course);

        foreach (var group in gstu)
        {
            // Key contains the value we grouped by
            Console.WriteLine($"Course: {group.Key}");

            // Each group contains the Student objects belonging to that course
            foreach (var student in group)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}