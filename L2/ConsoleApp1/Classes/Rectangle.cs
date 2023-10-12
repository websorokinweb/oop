using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class Rectangle
    {
        public double width;
        public double height;

        public Rectangle(double width, double height) {
            if(width <= 0 || height <= 0)
            {
                Console.WriteLine("Boki prostokątu muszą być dodatne");
                throw new ArgumentException("Wypełnij prawidlowo długość boków");
            }
            else
            {
                this.width = width;
                this.height= height;
            }
        }

        public double CalculateArea()
        {
            return width * height;
        }
    }
}
