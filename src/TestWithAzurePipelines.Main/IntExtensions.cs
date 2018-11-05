using System;
using System.Linq;

namespace TestWithAzurePipelines.Main
{

    public static class IntExtenstions
    {
        public static bool IsEven(this int number) => number % 2 == 0;
        public static bool IsOdd(this int number) => number % 2 != 0;

        public static bool IsPrime(this int number)
        {
            if (number == 1) return false;
            for (var i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        public static double Pow(this int number, double exponent) => Math.Pow(number, exponent);
    }

}