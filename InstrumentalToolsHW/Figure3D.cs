using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentalToolsHW
{
    interface Figure3D
    {
        Double Volume();
        Double SurfaceArea();
        Double EdgeLength();

        String ToString();
    }
}
