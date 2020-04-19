using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentalToolsHW
{
    class Rhombus : Figure
    {
        public double Side { get; private set; }
        public double Edge { get; private set; }

        public Rhombus(double side, double edge)
        {
            if (side <= 0 || edge > 90)
            {
                throw new Exception("side's lenght must be more than 0 or edge is too big");
            }
            Side = side;
            Edge = edge;
        }
        public override double Size()
        {
            return Side * Side * System.Math.Sin(Edge / 180 * System.Math.PI);
        }
        public override double Perimeter()
        {
            return 4 * Side;
        }

        public override string ToString()
        {
            return "Rectangle with side " +
                Side.ToString() + "and edge " +
                Edge.ToString();

        }
    }
}