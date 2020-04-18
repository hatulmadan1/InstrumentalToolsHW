using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentalTools
{
    public class Triangle : Figure
    {
        public double Side1 { get; private set; }
        public double Side2 { get; private set; }
        public double Side3 { get; private set; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new Exception("side's lenght must be more than 0");
            }
            Side1 = a;
            Side2 = b;
            Side3 = c;
        }

        public override double Size()
        {
            double p = (Side1 + Side2 + Side3) / 2.0;
            return System.Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        public override double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public override string ToString()
        {
            return "Triangle with sides " +
                Side1.ToString() + ", " +
                Side2.ToString() + ", " +
                Side3.ToString();
        }
    }
}
