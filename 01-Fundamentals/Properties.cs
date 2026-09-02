    using System;

    class Student
    {
        public int Id { get; set; }

        public string Name { get; private set ; } = "";


        public int Marks { get; } = 25;

        public void ChangeName(string newName)
        {
            Name = newName;
        }
    }

    class Properties
    {
        public static void Run()
        {
            Student s = new Student();
            s.Id = 123;
            // s.Name = "Yugansh";
            s.ChangeName("Yugansh");
            System.Console.WriteLine(s.Id);
            System.Console.WriteLine(s.Marks);
            System.Console.WriteLine(s.Name);


        }
    }