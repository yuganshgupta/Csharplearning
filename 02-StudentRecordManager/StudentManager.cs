using System.Collections.Generic;

namespace _02_StudentRecordManager;

class StudentManager
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void ShowStudents()
    {
            foreach(Student student in students)
            {
                System.Console.WriteLine($"Name : {student.Name}");
                System.Console.WriteLine($"ID : {student.Id}");
                System.Console.WriteLine($"Course : {student.Course}");
                System.Console.WriteLine($"Marks : {student.Marks}");

            }
        
    }


    public void ShowStudentByIndex(int index)
    {
        if(index >= 0 && index < students.Count)
        {

            Console.WriteLine($"Id :{students[index].Id}");
            Console.WriteLine($"Name : {students[index].Name}");
            Console.WriteLine($"Course : {students[index].Course}");
            Console.WriteLine($"Marks : {students[index].Marks}");
        }
        else
        {
            System.Console.WriteLine("Invalid student id index");
        }
    }

    public void RemoveStudentByIndex(int index)
    {
        if(index >= 0 && index < students.Count)
        {
            students.RemoveAt(index);
            Console.WriteLine("Student removed successfully");
        }
        else
        {
            Console.WriteLine("Invalid student index");
        }
    }

    public void RemoveStudent(Student student)
    {
        var check = students.Remove(student);
        if(!check)
        {
            System.Console.WriteLine("Invalid student id index");
        }
        else
        {
            System.Console.WriteLine("Student removed successfully");
        }
    }

    public void FindStudentById(int id)
    {
        foreach(Student student in students)
        {
            if(student.Id == id)
            {
                System.Console.WriteLine($"student found with id : {id}");
                return;
            }
        }
        Console.WriteLine("Student not found");
    }

    public void RemoveStudentById(int id)
    {
    Student? student = students.Find(s => s.Id == id);

    if (student == null)
    {
        Console.WriteLine("Student not found");
        return;
    }

    students.Remove(student);
    Console.WriteLine("Student removed successfully");
    }   



}