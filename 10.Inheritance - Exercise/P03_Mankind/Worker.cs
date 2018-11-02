using System;

namespace P03_Mankind
{
    class Worker : Human
    {
        private const decimal MINIMUM_SALARY = 10;
        private const int MIN_WORK_HOURS = 1;
        private const int MAX_WORK_HOURS = 12;
        private const int WORK_DAYS_IN_WEEK = 5;

        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get => weekSalary;
            set
            {
                if (value <= MINIMUM_SALARY)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get => workHoursPerDay;
            set
            {
                if (value < MIN_WORK_HOURS || value > MAX_WORK_HOURS)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                workHoursPerDay = value;
            }
        }

        private decimal GetSalaryPerHour
            => WeekSalary / WORK_DAYS_IN_WEEK / WorkHoursPerDay;

        public override string ToString()
            => base.ToString()
                + $"Week Salary: {WeekSalary:F2}{Environment.NewLine}"
                + $"Hours per day: {workHoursPerDay:F2}{Environment.NewLine}"
                + $"Salary per hour: {GetSalaryPerHour:F2}";
    }
}
