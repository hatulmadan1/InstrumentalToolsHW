using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentalToolsHW
{
    class Trapeze : Figure
    {
        public double Side1 { get; private set; }
        public double Side2 { get; private set; }
        public double Side3 { get; private set; }
        public double Side4 { get; private set; }

        public Trapeze(double a, double b, double c, double d)
        {
            if (a <= 0 || b <= 0 || c <= 0 || d <= 0)
            {
                throw new Exception("side's lenght must be more than 0");
            }
            Side1 = a;
            Side2 = b;
            Side3 = c;
            Side4 = d;
        }
        
        public override double Size()
        {
            return ((Side1 + Side2) / 2) *
                System.Math.Sqrt(Side3 * Side3 -
                System.Math.Pow((((Side2 - Side1) * (Side2 - Side1) + Side3 * Side3 - Side4 * Side4) / (2 * (Side2 - Side1))), 2));
        }
        public override double Perimeter()
        {
            return Side1 + Side2 + Side3 + Side4;
        }

        public override string ToString()
        {
            return "Trapeze with sides " +
                Side1.ToString() + ", and " +
                Side2.ToString() + ", and " +
                Side3.ToString() + ", and " +
                Side4.ToString();
        }
    }
}
