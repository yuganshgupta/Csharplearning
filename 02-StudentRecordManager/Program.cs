using System.Buffers;

namespace _02_StudentRecordManager;

class Program
{
    static void Main(string[] args)
    {
        // basically we are creating one manager so that we can add or remove students later with this one object only 
         var manage = new StudentManager();    
        // first student
        Student s1 = new Student(12,"Yugansh","CS",69);
        manage.AddStudent(s1);   
        

        Student s2 = new Student(11,"Suyash","CS",89);
        manage.AddStudent(s2);
        

        var s3 = new Student(10,"Nikhil","CS",99);
        manage.AddStudent(s3);
        

        manage.ShowStudents();

        Console.WriteLine("All Students:");
        manage.ShowStudents();

        Console.WriteLine("\nSearching student:");
        manage.FindStudentById(11);

        Console.WriteLine("\nRemoving student:");
        manage.RemoveStudentById(11);

        Console.WriteLine("\nStudents after removal:");
        manage.ShowStudents();
    }
}
