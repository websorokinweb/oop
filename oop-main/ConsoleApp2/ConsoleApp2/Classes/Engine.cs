using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classes
{
    internal class Engine
    {
        public Engine(float fuelCapacity, float fuelAmount, float fuelTankCapacity = 40.3f)
        {
            this.fuelCapacity = fuelCapacity;
            this.fuelAmount = fuelAmount;
            this.fuelTankCapacity = fuelTankCapacity;
            
            this.lkm = this.fuelTankCapacity * 4;
        }
        public float fuelCapacity;
        public float fuelAmount;
        public readonly float fuelTankCapacity;
        public readonly float lkm;
        public float MpgToLkm(float mpg)
        {
            return mpg * 235.21f;
        }
        public float LkmToMpg(float lkm)
        {
            return lkm / 235.21f;
        }
        public void Work(float distance)
        {
            this.fuelAmount -= this.lkm / 100 * distance;
        }
    }
}
