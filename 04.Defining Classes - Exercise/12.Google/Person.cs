namespace Google
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        private string name;
        private string birthday;
        private Company company;
        private Car car;
        private List<Pokemon> pokemons;
        private List<Person> parents;
        private List<Person> chilren;

        public Person(string name)
        {
            this.Name = name;
            this.Company = new Company();
            this.Car = new Car();
            this.Pokemons = new List<Pokemon>();
            this.Parents = new List<Person>();
            this.Children = new List<Person>();
        }

        public Person(string name, string birthday)
            :this(name)
        {
            this.Birthday = birthday;
        }

        public List<Person> Children
        {
            get { return chilren; }
            set { chilren = value; }
        }
        
        public List<Person> Parents
        {
            get { return parents; }
            set { parents = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }
        
        public Car Car
        {
            get { return car; }
            set { car = value; }
        }

        public Company Company
        {
            get { return company; }
            set { company = value; }
        }

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            string result = this.name + Environment.NewLine;
            result += "Company:" + Environment.NewLine;
            if (this.Company.Name != null)
            {
                result += $"{this.Company.Name} {this.Company.Department} {this.Company.Salary:f2}"
                + Environment.NewLine;
            }

            result += "Car:" + Environment.NewLine;
            if (this.Car.Modle != null)
            {
                result += $"{this.Car.Modle} {this.Car.Speed}" + Environment.NewLine;
            }

            result += "Pokemon:" + Environment.NewLine;
            foreach (var pokemon in this.Pokemons)
            {
                result += $"{pokemon.Name} {pokemon.Type}" + Environment.NewLine;
            }

            result += "Parents:" + Environment.NewLine;
            foreach (var parent in this.Parents)
            {
                result += $"{parent.Name} {parent.Birthday}" + Environment.NewLine;
            }

            result += "Children:" + Environment.NewLine;
            foreach (var child in this.Children)
            {
                result += $"{child.Name} {child.Birthday}" + Environment.NewLine;
            }

            return result;
        }
    }
}
