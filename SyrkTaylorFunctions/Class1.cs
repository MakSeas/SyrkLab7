using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyrkTaylorFunctions
{
    public static class DegreeConverter
    {
        public static double ToRadians(double value)
        {
            return value * Math.PI / 180.0f;
        }

        public static double ToDegrees(double value)
        {
            return value * 180 / Math.PI;
        }
    }
}
