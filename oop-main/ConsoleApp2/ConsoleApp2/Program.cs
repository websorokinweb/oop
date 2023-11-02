using ConsoleApp2.Classes;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Mercedes-Benz", "AMG", 32, 21);
            car.DisplayInfo();

            car.Ride(3);
            car.Ride(13);
            car.Refuel(30);
            car.DisplayInfo();
            car.Ride(13);
        }
    }
}