namespace P03_StudentSystem
{
    using System;

    class StartUp
    {
        static void Main()
        {
            StudentSystem studentSystem = new StudentSystem();
            string input;
            while ((input = Console.ReadLine()) != "Exit")
            {
                string[] args = input.Split();
                string command = args[0];
                string name = args[1];

                switch (command)
                {
                    case "Create":
                        var age = int.Parse(args[2]);
                        var grade = double.Parse(args[3]);
                        studentSystem.CreateStudent(name, age, grade);
                        break;
                    case "Show":
                        Console.WriteLine(studentSystem.StudentInfo(name));
                        break;
                }
            }
        }
    }
}
