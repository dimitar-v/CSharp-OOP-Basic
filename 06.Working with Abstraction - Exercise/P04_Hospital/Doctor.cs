using System.Collections.Generic;

namespace P04_Hospital
{
    class Doctor
    {
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public List<string> Patients { get; set; }

        public Doctor(string fisrtName, string lastName)
        {
            FisrtName = fisrtName;
            LastName = lastName;
            Patients = new List<string>();
        }

        public string FullName()
            => FisrtName + LastName;
    }
}
