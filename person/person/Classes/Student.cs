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
            if (this.address != null)
            {
                return $"Student\n{getFullName()}\n{address.getAddress()}\nNumer studenta: {studentNumber}";
            }
            return $"Student\n{getFullName()}\nNumer studenta: {studentNumber}";

        }
        public Student(string name, string surname, DateTime dateOfBirth, string studentNumber) : base(name, surname, dateOfBirth)
        {
            this.studentNumber = studentNumber;
        }
        public Student(string name, string surname, DateTime dateOfBirth, Address address, string studentNumber) : base(name, surname, dateOfBirth, address)
        {
            this.studentNumber = studentNumber;
        }
    }
}
