using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyrkTaylorFunctions
{
    public static class Precision
    {
        public static double GetDoubleWithPrecision(double value, int precision)
        {
            int divider = (int)Math.Pow(10, precision);
            int buffer = (int)(value * divider);

            double result = (double)buffer/divider;

            return result;
        }
    }
}
