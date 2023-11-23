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
            Console.WriteLine("\nProgram do zarządzania użytkownikami\n1 - Dodaj użytkownika\n2 - Wyświetl użytkowników\n3 - Usuń wszystkich użytkowników\n4 - Wyjdź");
            return int.Parse(Console.ReadLine());
        }
    }
}
