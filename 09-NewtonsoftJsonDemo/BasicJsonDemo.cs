namespace _09_NewtonsoftJsonDemo;

using Newtonsoft.Json;

internal static class BasicJsonDemo
{
    internal static void Run()
    {
        var st1 = new Student
        {
            Name = "Yugansh",
            Age = 22,
            Course = "MCA"
        };

        // Converts the Student object into a JSON string
        // Formatting.Indented makes the JSON easier to read
        string json = JsonConvert.SerializeObject(st1, Formatting.Indented);

        Console.WriteLine(json);

        // Converts the JSON string back into a Student object
        Student? cst1 = JsonConvert.DeserializeObject<Student>(json);

        Console.WriteLine(cst1?.Name);
        Console.WriteLine(cst1?.Age);
        Console.WriteLine(cst1?.Course);

        // Save the Student object into student.json
        JsonFileDemo.SaveStudent(st1);

        // Load the JSON file back into a Student object
        Student? loadedStudent = JsonFileDemo.LoadStudent();

        Console.WriteLine("Student loaded from file:");
        Console.WriteLine(loadedStudent?.Name);
        Console.WriteLine(loadedStudent?.Age);
        Console.WriteLine(loadedStudent?.Course);
    }
}