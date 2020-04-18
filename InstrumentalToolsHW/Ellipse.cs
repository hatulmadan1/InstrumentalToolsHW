﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentalToolsHW
{
    class Ellipse : Figure
    {
        public double Semiaxis1 { get; private set; }
        public double Semiaxis2 { get; private set; }
        public override double Perimeter()
        {
            return 2.0 * System.Math.PI * System.Math.Sqrt((Semiaxis1 * Semiaxis1 + Semiaxis2 * Semiaxis2) / 2);
        }

        public override double Size()
        {
            return System.Math.PI * Semiaxis1 * Semiaxis2;
        }

        public override string ToString()
        {
            return "Ellipse with sides " +
                Semiaxis1.ToString() + " and " +
                Semiaxis2.ToString();
        }
    }
}
