using System;
using Newtonsoft.Json.Linq;

namespace _09_NewtonsoftJsonDemo;

internal static class JTokenDemo
{
    internal static void Run()
    {
        // getting the path of the json file from the runtime folder
        string fp = Path.Combine(AppContext.BaseDirectory, "student-data.json");

        if (!File.Exists(fp))
        {
            // in case we cant read or find the json file
            Console.WriteLine("File not found");
            return;
        }

        try
        {
            Console.WriteLine("----- Reading JSON File -----");

            // reading the json file as normal text first
            string json = File.ReadAllText(fp);

            Console.WriteLine("JSON file loaded successfully");


            Console.WriteLine("\n----- Parsing JSON -----");

            // parsing the json once so now we can move through it like a tree
            JToken root = JToken.Parse(json);

            Console.WriteLine($"Root type: {root.GetType().Name}");


            Console.WriteLine("\n----- Student Object -----");

            // getting the student object from the root
            JToken? stu = root["student"];

            if (stu is not null)
            {
                Console.WriteLine($"Student token type: {stu.GetType().Name}");

                // getting the name value from inside the student object
                JToken? name = stu["name"];

                Console.WriteLine($"Name directly from JToken: {name}");


                Console.WriteLine("\n----- ToObject<StudentInfo>() -----");

                // converting the student part of the json into a normal C# object
                StudentInfo? stuinfo = stu.ToObject<StudentInfo>();

                if (stuinfo is not null)
                {
                    Console.WriteLine($"Student Name: {stuinfo.Name}");
                    Console.WriteLine($"Student Marks: {stuinfo.Marks}");
                }
            }


            Console.WriteLine("\n----- Subjects Array -----");

            // getting subjects from the root
            // keeping it as JToken first because we still need to check its actual type
            JToken? subjectsToken = root["subjects"];

            Console.WriteLine(
                $"Subjects token type: {subjectsToken?.GetType().Name}"
            );


            // checking if subjects is actually a JArray
            // if yes subjects becomes our JArray variable
            if (subjectsToken is JArray subjects)
            {
                Console.WriteLine($"Number of subjects: {subjects.Count}");

                // going through each item inside the subjects array
                foreach (JToken subjectToken in subjects)
                {
                    Console.WriteLine(
                        $"\nSubject token type: {subjectToken.GetType().Name}"
                    );

                    // each item inside this array should be a JObject
                    if (subjectToken is JObject subject)
                    {
                        // now that we know subject is an object
                        // we can access the values inside it
                        JToken? nameToken = subject["name"];
                        JToken? scoreToken = subject["score"];

                        if (nameToken is not null && scoreToken is not null)
                        {
                            Console.WriteLine("Converting JToken values into C# values");

                            var name = nameToken.Value<string>();
                            var score = scoreToken.Value<int>();

                            Console.WriteLine($"Subject Name: {name}");
                            Console.WriteLine($"Subject Score: {score}");
                        }
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception occured");
            Console.WriteLine(e.Message);
        }
    }
}