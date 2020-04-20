using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentalToolsHW
{
    public class point
    {
        public double x,y;
    }
    interface ILine
    {
        double getLength(point x, point y);
    }
}
