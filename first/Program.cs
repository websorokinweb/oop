namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wpisz bok a: ");
            string newAString = Console.ReadLine();
            Console.Write("Wpisz bok b: ");
            string newBString = Console.ReadLine();
            Console.Write("Wpisz bok c: ");
            string newCString = Console.ReadLine();
            double newA = double.Parse(newAString);
            double newB = double.Parse(newBString);
            double newC = double.Parse(newCString);

            Triangle triangle = new Triangle(newA, newB, newC);
            if(triangle.isReal() )
            {
                Console.WriteLine(triangle.getHerone());
            }
        }
    }
}