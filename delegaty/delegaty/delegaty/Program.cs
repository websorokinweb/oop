namespace delegaty
{
    public delegate int Operation(int x, int y);
    internal class Program
    {

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            return x + y;
        }

        public static void DisplayResult(Operation op, int x, int y)
        {
            int result;
            if (op.Method.Name == "Divide" && y == 0)
            {
                Console.WriteLine("\nBłąd: dzielenie przez 0");
                result = 0;
            } else
            {
                result = op(x, y);
                Console.WriteLine($"Wynik operacji {op.Method.Name} na liczbach {x} i {y} to {result}");
            }
        }

        public static int GetIntFromUser(string prompt)
        {
            bool isActing = true;
            int number = 1;
            string? input;
            bool isValid;
            while (isActing)
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();
                isValid = int.TryParse(input, out number) && number > 0;
                if(isValid)
                {
                    isActing = false;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowe dane. Podaj liczbę całkowitą nieujemną.");
                }
            }
            return number;
        }

        static void Main(string[] args)
        {
            int a = GetIntFromUser("Podaj pierwszą liczbę");
            int b = GetIntFromUser("Podaj drugą liczbę");

            Operation add = Add;
            Operation subtract = Subtract;
            Operation multiply = Multiply;
            Operation divide = Divide;

            DisplayResult(add, a, b);
            DisplayResult(subtract, a, b);
            DisplayResult(multiply, a, b);
            DisplayResult(divide, a, b);

        }
    }
}