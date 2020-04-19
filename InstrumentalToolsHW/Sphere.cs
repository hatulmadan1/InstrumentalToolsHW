using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentalToolsHW
{
    class Sphere : Figure3D
    {
        public double Radius { get; private set; }

        public Sphere(double radius)
        {
            if (radius <= 0)
            {
                throw new Exception("radius must be more than zero");
            }
            Radius = radius;
        }
        public double EdgeLength()
        {
            throw new NotImplementedException();
        }

        public double SurfaceArea()
        {
            return 4.0 * System.Math.PI * Radius * Radius;
        }

        public double Volume()
        {
            return 4.0 * System.Math.PI * Radius * Radius * Radius / 3.0;
    }
}
