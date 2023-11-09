using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person.Classes
{
    internal class Student: Person
    {
        public string studentNumber;
        public string getInfo()
        {
            return $"Student\n{getFullName()}\n{address.getAddress()}\nNumer studenta: {studentNumber}";
        }
        public Student(string name, string surname, DateTime dateOfBirth, Address address, string studentNumber) : base(name, surname, dateOfBirth, address)
        {
            this.studentNumber = studentNumber;
        }
    }
}
