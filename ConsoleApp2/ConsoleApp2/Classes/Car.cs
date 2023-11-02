using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classes
{
    internal class Car
    {
        public string brand;
        public string model;
        public Engine engine;
        
        public Car(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }
        public Car(string brand, string model, Engine engine) : this(brand, model)
        {
            this.engine = engine;
        }
        public Car(string brand, string model, float fuelCapacity, float fuelAmount) : this(brand, model)
        {
            this.engine = new Engine(fuelCapacity, fuelAmount);
        }
        public Car(string brand, string model, float fuelCapacity, float fuelAmount, float fuelTankCapacity) : this(brand, model)
        {
            this.engine = new Engine(fuelCapacity, fuelAmount, fuelTankCapacity);
        }
        public void DisplayInfo()
        {
            Console.WriteLine("\n===");
            Console.WriteLine($"{this.model} {this.brand} \nPojemność paliwa: {this.engine.fuelCapacity} l \nIlość paliwa: {this.engine.fuelAmount} l \nPojemność zbiornika na paliwo: {this.engine.fuelTankCapacity} l");
            Console.WriteLine("===\n");
        }
        public void Ride(float distance)
        {
            

            float remainedDistance = distance;
            if (this.engine.fuelAmount >= this.engine.lkm / 100 * distance) {
                this.engine.Work(distance);

                for (int i = 0; i <= 10; i++)
                {
                    Console.Clear();
                    Console.WriteLine("\nJadę...\n");

                    Console.WriteLine($"{new string('=', i)}>{new string('=', 10 - i)}");
                    Thread.Sleep((int)Math.Ceiling((distance * 100) / 10));
                }
                Console.WriteLine($"\nJestem, zostało {this.engine.fuelAmount} l paliwa");
            }
            else
            {
                float passedDistance = this.engine.fuelAmount / (this.engine.lkm / 100);

                remainedDistance -= passedDistance;
                float passedInPercents = passedDistance / (distance / 100);
                int passedInPercentsCeiledTo10 = ((int)Math.Round(passedInPercents / 10.0)) * 10;
                Console.WriteLine($"Pokonano drogi {passedInPercentsCeiledTo10}");

                for (int i = 0; i <= 10; i++)
                {
                    Console.Clear();
                    Console.WriteLine("\nJadę...\n");

                    Console.WriteLine($"{new string('=', i)}>{new string('=', 10 - i)}{new string('=', 10 - passedInPercentsCeiledTo10 / 10)}");
                    Thread.Sleep((int)Math.Ceiling((distance * 100) / 10));
                }

                Thread.Sleep((int)Math.Ceiling(passedDistance * 100));
                Console.WriteLine($"\nBenzyna się skończyła, zostało pokonać jeszcze {remainedDistance} km. Dotankuj samochód");
            }

        }
        public void Refuel(float fuelAmount)
        {
            if (this.engine.fuelAmount + fuelAmount > this.engine.fuelTankCapacity)
            {
                // throw new Exception("Checesz zatankować za dużo paliwa");
                Console.WriteLine("\n===");
                Console.WriteLine("Checesz zatankować za dużo paliwa. Tankuję do maxa");
                Console.WriteLine("===\n");
                this.engine.fuelAmount = this.engine.fuelTankCapacity;
            }
            else
            {
                this.engine.fuelAmount += fuelAmount;
            }
        }
    }
}
