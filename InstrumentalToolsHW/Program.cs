using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentalTools
{
    public class Program
    {
        static void Main(string[] args)
        {
            Figure A = new Rectangle(2.34, 43.12);
            System.Console.WriteLine(A.Size());

            Figure B = new Round(4.13);
            System.Console.WriteLine(B.Size());

            Figure C = new Triangle(3.7, 3.9, 3.5);
            System.Console.WriteLine(C.Size());
        }
    }
}
