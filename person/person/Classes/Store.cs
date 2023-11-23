using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person.Classes
{
    internal class Store
    {
        public List<Person> users = new List<Person> { };
        public void AddUser(string userType)
        {
            Console.WriteLine("Podaj imię");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko");
            string surname = Console.ReadLine();
            Console.WriteLine("Podaj datę urodzenia (RRRR-MM-DD):");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

            if (userType == "student")
            {
                Console.WriteLine("Podaj indeks studentu");
                string studentNumber = Console.ReadLine();
                users.Add(new Student(name, surname, dateOfBirth, studentNumber));
            }
            else if (userType == "teacher")
            {
                Console.WriteLine("Podaj pzedmioty (przez przecinek)");
                string subjects = Console.ReadLine();
                List<string> subjectsFormatted = subjects.Split(',').ToList();
                users.Add(new Teacher(name, surname, dateOfBirth, subjectsFormatted));
            }
            else
            {
                users.Add(new Person(name, surname, dateOfBirth));
            }

            Console.WriteLine("\nUżytkownik został dodany!");
        }
        public void RemoveAllUsers()
        {
            this.users.Clear();
            Console.WriteLine("\nWszyscy użytkownicy zostały usunięci");
        }
        public void DisplayUsers(string userType)
        {
            if (users.Count == 0)
            {
                Console.WriteLine("\nNie ma żadnych użytkowników");
            }
            else
            {
                Console.Clear();
                foreach (Person user in users)
                {
                    if(user is Student) {
                        Console.WriteLine(((Student)user).getInfo());
                    }
                    else if (user is Teacher)
                    {
                        Console.WriteLine(((Teacher)user).getInfo());
                    }
                    else
                    {
                        Console.WriteLine(user.getInfo());
                    }
                }
            }
        }
    }
}
