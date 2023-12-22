using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyrkTaylorFunctions
{
    internal interface ITaylorHandable
    {
        double Taylor(double argument, int precision);
    }
}
