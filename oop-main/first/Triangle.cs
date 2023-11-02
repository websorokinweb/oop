using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    public class Triangle
    {
        public double a
        { get; set; }
        public double b
        { get; set; }
        public double c
        { get; set; }
        public bool isReal()
        {
            if(a + b <= c || a + c <= b || c + b <= a)
            {
                return false;
            }
            return true;
        }

        public double getHerone()
        {
            double p = (a+b+c)/2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }

        public Triangle(double initA, double initB, double initC)
        {
            a = initA;
            b = initB;
            c = initC;
        }
    }
}
