using person.Classes;

namespace person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Address personAddress = new Address("Poznań", "Słowiańska", "2A", "61-630");
            //Person person = new Person("Bohdan", "Trubiuk", new DateTime(2005, 10, 9), personAddress);
            //Student student = new Student("Bohdan", "Trubiuk", new DateTime(2005, 10, 9), personAddress, "2000");

            //Address teacherAddress = new Address("Poznań", "Słowiańska", "2A", "61-630");
            //Teacher teacher = new Teacher("NieBohdan", "NieTrubiuk", new DateTime(1980, 9, 10), teacherAddress, new List<string>() { "oop", "coding for begginers" } );

            //Console.WriteLine(person.getInfo());
            //Console.WriteLine("");
            //Console.WriteLine(student.getInfo());
            //Console.WriteLine("");
            //Console.WriteLine(teacher.getInfo());

            Store store = new Store();

            bool isDisplaying = true;
            while (isDisplaying)
            {
                int chosenOption = Menu.DisplayMenu();
                switch (chosenOption)
                {
                    case 1:
                        store.AddUser();
                        break;
                    case 2:
                        store.DisplayUsers();
                        break;
                    case 3:
                        store.RemoveAllUsers();
                        break;
                    case 4:
                        isDisplaying = false;
                        break;
                    default:
                        Console.WriteLine($"{chosenOption} nie jest na liście dostępnych metod");
                        break;
                }
            }
        }
    }
}