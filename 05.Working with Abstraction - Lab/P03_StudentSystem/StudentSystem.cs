namespace P03_StudentSystem
{
    using System;
    using System.Collections.Generic;

    public class StudentSystem
    {
        private Dictionary<string, Student> repo;

        public StudentSystem()
        {
            this.Repo = new Dictionary<string, Student>();
        }

        public Dictionary<string, Student> Repo
        {
            get { return repo; }
            private set { repo = value; }
        }

        public void CreateStudent(string name, int age, double grade)
        {
            if (!Repo.ContainsKey(name))
            {
                var student = new Student(name, age, grade);
                Repo[name] = student;
            }
        }

        public string StudentInfo(string name)
        {
            if (!Repo.ContainsKey(name))
            {
                return "";
            }

            return Repo[name].ToString();
        }
    }
}
