namespace _09_NewtonsoftJsonDemo;

using Newtonsoft.Json;

internal static class JsonFileDemo
{
    public static void SaveStudent(Student student)
    {
        // Converting the Student object into JSON text
        string json = JsonConvert.SerializeObject(
            student,
            Formatting.Indented
        );

        // Creating the full path where student.json will be saved
        string filePath = Path.Combine(
            AppContext.BaseDirectory, // AppContext.BaseDirectory : base directory of the application.
            // Here it is : Csharplearning\09-NewtonsoftJsonDemo\bin\Debug\net10.0\
            "student.json"
        );

        // Writing the JSON text into the file
        // Creates the file if it doesn't exist and overwrites it if it already exists
        File.WriteAllText(filePath, json);

        Console.WriteLine($"Student saved to: {filePath}");
    }


    public static Student? LoadStudent()
    {
        // Creating the full path of the student.json file
        string filePath = Path.Combine(
            AppContext.BaseDirectory,
            "student.json"
        );

        // Checking whether the file actually exists before trying to read it
        if (!File.Exists(filePath))
        {
            Console.WriteLine("student.json was not found.");
            return null;
        }

        try
        {
            // tries to read all the text from the specified file path -> student.json
            string json = File.ReadAllText(filePath);


            // deserializes the json to c# object 
            Student? student =
                JsonConvert.DeserializeObject<Student>(json);

            return student;
        }

        catch (JsonException ex)
        {
            Console.WriteLine("The JSON file contains invalid data.");
            Console.WriteLine(ex.Message);

            return null;
        }
    }

}