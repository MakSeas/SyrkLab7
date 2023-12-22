using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyrkTaylorFunctions
{
    public static class Tangens
    {
        public static double Taylor(double argument, int precision)
        {
            double result = 0;
            double prevDigits = 0;
            int n = 0;

            int mult = 1;

            while (true)
            {
                double term = mult * Math.Pow(argument, n) / Functions.Factorial(n);
                result += term;

                mult *= -2;

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
