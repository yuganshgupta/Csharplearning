using System;
using System.Collections.Generic;
using System.Text;

namespace _11_LinqDemo;

internal static class QuerySyntaxDemo
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

        var result =
            from student in students
            where student.Course == "MCA"
            orderby student.Marks descending
            select student.Name;


        foreach(var res in result)
        {
            Console.WriteLine(res);
        }
    }
}
