using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class StartUp
    {
        static List<Doctor> doctors;
        static List<Department> departments;

        public static void Main()
        {
            doctors = new List<Doctor>();
            departments = new List<Department>();


            string command;
            while ((command = Console.ReadLine()) != "Output")
            {
                string[] info = command.Split();
                var departmentName = info[0];
                var firstName = info[1];
                var lastName = info[2];
                var patient = info[3];
                var fullName = firstName + lastName;

                Doctor doctor = GetDoctor(firstName, lastName);
                Department department = GetDepartment(departmentName);
                
                bool isFreeBeds = department.Rooms.Sum(r => r.Patients.Count()) < 60;
                if (isFreeBeds)
                {
                    doctor.Patients.Add(patient);

                    int targetRoom = 0;
                    for (int room = 0; room < department.Rooms.Count; room++)
                    {
                        if (department.Rooms[room].Patients.Count < 3)
                        {
                            targetRoom = room;
                            break;
                        }
                    }
                    department.Rooms[targetRoom].Patients.Add(patient);
                }
            }

            while ((command = Console.ReadLine()) != "End")
            {
                string[] args = command.Split();
                if (args.Length == 1)
                {
                    GetDepartment(args[0]).Rooms
                        .Where(r => r.Patients.Count > 0)
                        .ToList()
                        .ForEach(r => r.Patients
                            .ForEach(Console.WriteLine));
                }
                else if (args.Length == 2 && int.TryParse(args[1], out int room))
                {
                    GetDepartment(args[0]).Rooms[room - 1].Patients
                        .OrderBy(n => n)
                        .ToList()
                        .ForEach(Console.WriteLine);
                }
                else
                {
                    GetDoctor(args[0], args[1]).Patients
                        .OrderBy(n => n)
                        .ToList()
                        .ForEach(Console.WriteLine);
                }
            }
        }

        private static Department GetDepartment(string departmentName)
        {
            Department department = departments.FirstOrDefault(d => d.Name == departmentName);

            if (department == null)
            {
                department = new Department(departmentName);
                for (int i = 0; i < 20; i++)
                {
                    department.Rooms.Add(new Room());
                }

                departments.Add(department);
            }

            return department;
        }

        private static Doctor GetDoctor(string firstName, string lastName)
        {
            Doctor doctor = doctors.FirstOrDefault(d => d.FisrtName == firstName && d.LastName == lastName);

            if (doctor == null)
            {
                doctor = new Doctor(firstName, lastName);
                doctors.Add(doctor);
            }

            return doctor;
        }
    }
}
