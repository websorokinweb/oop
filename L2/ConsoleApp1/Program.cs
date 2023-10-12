using ConsoleApp1.Classes;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sideA = Helpers.SaveUserDouble("Podaj stronę A:", "Nieprawidlowa liczba, sprobój ponownie: ");
            double sideB = Helpers.SaveUserDouble("Podaj stronę B:", "Nieprawidlowa liczba, sprobój ponownie: ");

            try
            {
                Rectangle rectangle = new Rectangle(sideA, sideB);
                Console.Write($"Pole prostokąta o bokach {sideA} oraz {sideB} wynosi: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.Write($"{rectangle.CalculateArea()}cm\u00B2");
                Console.ResetColor();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}