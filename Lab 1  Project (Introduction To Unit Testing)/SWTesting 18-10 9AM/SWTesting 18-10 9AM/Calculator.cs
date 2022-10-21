using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWTesting_18_10_9AM
{
    public static class Calculator
    {
        public static double divide(double num1, double num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
                return double.NaN;
        }
    }
}
