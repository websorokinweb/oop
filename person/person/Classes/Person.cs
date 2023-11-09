using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person.Classes
{
    internal class Person
    {
        public string name;
        public string surname;
        public DateTime dateOfBirth;
        public Address address;

        public string getFullName()
        {
            return $"{this.name} {this.surname}, {this.Age()} lat";
        }

        public int Age()
        {
            TimeSpan difference = DateTime.Now - dateOfBirth;
            return (int)(difference.Days / 365.25);
        }

        public string getInfo()
        {
            return $"{getFullName()}\n{address.getAddress()}";
        }

        public Person(string name, string surname, DateTime dateOfBirth, Address address)
        {
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
        }
    }
}
