using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyrkTaylorFunctions
{
    public static class Sinus
    {
        public static double Taylor(double argument, int precision)
        {
            double result = 0;
            double prevDigits=0;
            int n = 0;

            while (true)
            {
                double term = Math.Pow(-1, n) * Math.Pow(argument, 2 * n + 1) / Functions.Factorial(2 * n + 1);

                result += term;
                int digits = (int)(result * Math.Pow(10, precision));

                if (n != 0 && digits == prevDigits)
                {
                    break;
                }

                prevDigits = digits;
                n++;
            }

            return Precision.GetDoubleWithPrecision(result, precision);
        }
    }
}
