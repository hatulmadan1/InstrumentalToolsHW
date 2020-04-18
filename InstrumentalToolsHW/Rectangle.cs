using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentalToolsHW
{
    public class Rectangle : Figure
    {
        public double Side1 { get; private set; }
        public double Side2 { get; private set; }

        public Rectangle (double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new Exception("side's lenght must be more than 0");
            }
            Side1 = a;
            Side2 = b;
        }
        /// <summary>
        /// calculates size of rectangle
        /// </summary>
        /// <returns>double, size of rectangle</returns>
        public override double Size()
        {
            return Side1 * Side2;
        }

        /// <summary>
        /// calculates perimeter of rectangle
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return 2 * Side1 + 2 * Side2;
        }

        public override string ToString()
        {
            return "Rectangle with sides " + 
                Side1.ToString() + " and " + 
                Side2.ToString();
        }
    }
}
