using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person.Classes
{
    internal class Store
    {
        public List<Person> persons = new List<Person> { };
        public void AddUser()
        {
            Console.WriteLine("Podaj imię");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko");
            string surname = Console.ReadLine();
            Console.WriteLine("Podaj datę urodzenia (RRRR-MM-DD):");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

            persons.Add(new Person(name, surname, dateOfBirth));
            Console.WriteLine("\nUżytkownik został dodany!");
        }
        public void RemoveAllUsers()
        {
            this.persons.Clear();
            Console.WriteLine("\nWszyscy użytkownicy zostały usunięci");
        }
        public void DisplayUsers()
        {
            if (persons.Count == 0)
            {
                Console.WriteLine("\nNie ma żadnych użytkowników");
            }
            else
            {
                Console.Clear();
                foreach (Person person in persons)
                {
                    Console.WriteLine(person.getInfo());
                }
            }
        }
    }
}
