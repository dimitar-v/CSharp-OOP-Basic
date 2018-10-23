using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var employees = new List<Employee>();

            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var name = input[0];
                var salary = decimal.Parse(input[1]);
                var position = input[2];
                var department = input[3];

                switch (input.Length)
                {
                    case 4:
                        employees.Add(new Employee(name, salary, position, department));
                        break;
                    case 5:
                        {
                            int age;
                            if (int.TryParse(input[4],out age))
                            {
                                employees.Add(new Employee(name, salary, position, department, age));
                            }
                            else
                            {
                                employees.Add(new Employee(name, salary, position, department, input[4]));
                            }
                        }
                        break;
                    case 6:
                        {
                            var email = input[4];
                            var age = int.Parse(input[5]);
                            employees.Add(new Employee(name, salary, position, department, email, age));
                        }
                        break;
                }
            }

            var departmentAverageSalary =
                from employee in employees
                group employee by employee.Department into departmantGroup
                select new
                {
                    Department = departmantGroup.Key,
                    AverageSalary = departmantGroup.Average(e => e.Salary)
                };

            string topDepartment = departmentAverageSalary
                .OrderByDescending(x => x.AverageSalary)
                .First()
                .Department;

            // variant 2
            //string topDepartment = employees.GroupBy(e => e.Department)
            //                                .OrderByDescending(x => x.Average(s => s.Salary))
            //                                .FirstOrDefault().Key;

            Console.WriteLine("Highest Average Salary: " + topDepartment);
            employees.Where(e => e.Department == topDepartment)
                .OrderByDescending(e => e.Salary)
                .ToList()
                .ForEach(e => Console.WriteLine($"{e.Name} {e.Salary:F2} {e.Email} {e.Age}"));
        }
    }
}
