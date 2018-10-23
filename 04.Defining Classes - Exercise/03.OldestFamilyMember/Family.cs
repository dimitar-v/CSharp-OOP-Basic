using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OldestFamilyMember
{
    public class Family
    {
        private List<Person> members;

        public Family()
        {
            this.Members = new List<Person>();
        }

        public List<Person> Members
        {
            get => this.members;
            set => this.members = value;
        }

        public void AddMember(Person member)
        {
            if (member == null)
            {
                throw new Exception();
            }

            this.Members.Add(member);
        }

        public Person GetOldestMember() =>
            this.Members.OrderByDescending(m => m.Age).FirstOrDefault();
    }
}
