using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person.Classes
{
    internal class Menu
    {
        public static int DisplayMenu()
        {
            Console.WriteLine("\nProgram do zarządzania użytkownikami\n1 - Dodaj użytkownika\n2 - Dodaj studenta\n3 - Dodaj nauczyciela\n4 - Wyświetl wszystkich użytkowników\n5 - Wyświetl tylko studentów\n6 - Wyświetl tylko nauczycieli\n7 - Usuń wszystkich użytkowników\n8 - Wyjdź");
            return int.Parse(Console.ReadLine());
        }
    }
}
