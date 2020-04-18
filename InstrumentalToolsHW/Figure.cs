using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentalTools
{
    abstract public class Figure
    {
        public abstract double Size();
        public abstract double Perimeter();
        public abstract new string ToString();
    }
}
