namespace _09_NewtonsoftJsonDemo;
using Newtonsoft.Json;

internal class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        var st1 = new Student
        {
            Name = "Yugansh",
            Age = 22,
            Course = "MCA"
        };


        // string json store the object we created in string 
        // JsonConvert.SerializeObject(...) Converts a C# object into JSON format
        // st1 The student object that we want to convert into JSON
        // Indented : Makes the JSON output easier to read by adding indentation and line breaks
        string json = JsonConvert.SerializeObject( st1,Formatting.Indented );

        Console.WriteLine(json);

        // Converting the JSON string back into a Student object
        Student? cst1 = JsonConvert.DeserializeObject<Student>(json);

        Console.WriteLine(cst1?.Name);
        Console.WriteLine(cst1?.Age);
        Console.WriteLine(cst1?.Course);

        JsonFileDemo.SaveStudent(st1);

        // Loading all the contents from the file student.json wvia the Loadstudent function back in the object form
        Student? loadedStudent = JsonFileDemo.LoadStudent();

        Console.WriteLine("Student loaded from file:");
        Console.WriteLine(loadedStudent?.Name);
        Console.WriteLine(loadedStudent?.Age);
        Console.WriteLine(loadedStudent?.Course);
    }
}
