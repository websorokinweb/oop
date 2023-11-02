using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class Helpers
    {
        public static double SaveUserDouble(string message, string errorMessage)
        {
            double correctUserInput;
            string userInput;

            Console.Write(message + " ");
            userInput = Console.ReadLine();
            while (!Double.TryParse(userInput, out correctUserInput))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(errorMessage + " ");
                Console.ResetColor();
                userInput = Console.ReadLine();
            }
            return correctUserInput;
        }
    }
}
