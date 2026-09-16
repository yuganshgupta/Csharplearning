namespace _11_LinqDemo;

internal static class JoinDemo
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

        var teach = new List<CourseInfo>
        {
            new() { Course = "MCA", Name = "Samyak" },
            new() { Course = "BCA", Name = "Nikshay" }
        };

        // Join combines two collections using a common matching key
        var result = stu.Join(

            // Second collection
            teach,

            // Key from Student
            student => student.Course,

            // Key from CourseInfo
            courseInfo => courseInfo.Course,

            // Runs when both Course values match
            // Creates a temporary anonymous object using data from both sides
            (student, courseInfo) => new
            {
                CourseName = student.Course,
                Name = student.Name,
                TeacherName = courseInfo.Name
            }
        );

        foreach (var student in result)
        {
            Console.WriteLine(
                $"{student.CourseName} | {student.Name} | {student.TeacherName}"
            );
        }
    }
}