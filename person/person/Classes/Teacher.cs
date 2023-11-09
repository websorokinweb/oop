using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person.Classes
{
    internal class Teacher: Person
    {
        public List<string> subjects;
        public string getSubjects()
        {
            return string.Join(", ", subjects.ToArray());
        }
        public string getInfo()
        {
            return $"Nauczyciel\n{getFullName()}\n{address.getAddress()}\nPrzedmioty: {getSubjects()}";
        }
        public Teacher(string name, string surname, DateTime dateOfBirth, Address address, List<string> subjects): base(name, surname, dateOfBirth, address)
        {
            this.subjects = subjects;
        }
    }
}
