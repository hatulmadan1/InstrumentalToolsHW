using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentalTools
{
    public class Round : Figure
    {
        public double Radius { get; private set; }

        public Round(double radius)
        {
            if (radius <= 0)
            {
                throw new Exception("radius must be more than zero");
            }
            Radius = radius;
        }
        public override double Size()
        {
            return this.Radius * this.Radius * System.Math.PI;
        }

        public override double Perimeter()
        {
            return 2 * System.Math.PI * Radius;
        }

        public override string ToString()
        {
            return "Round with radius " + Radius.ToString();
        }
    }
}
