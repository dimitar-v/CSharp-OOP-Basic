namespace Google
{
    public class Company
    {
        private string name;
        private string department;
        private decimal salary;

        public Company()
        {

        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
