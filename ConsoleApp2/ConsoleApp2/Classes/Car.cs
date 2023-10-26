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
            Console.WriteLine($"{this.model} {this.brand} \nPojemność paliwa: {this.engine.fuelCapacity} l \nIlość paliwa: {this.engine.fuelAmount} l \nPojemność zbiornika na paliwo: {this.engine.fuelTankCapacity} l");
        }
        public void Ride(float distance)
        {
            Console.WriteLine("Jadę");

            this.engine.Work(distance);
            Thread.Sleep((int)Math.Ceiling(distance * 100));

            Console.WriteLine($"Jestem, zostało {this.engine.fuelAmount}l paliwa");
        }
        public void Refuel(float fuelAmount)
        {
            this.engine.fuelAmount = fuelAmount;
        }
    }
}
