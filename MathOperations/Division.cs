using System;

namespace MathOperations
{
    public static class Division : IDivide
    {
        static public int Quotient(int a, int b)
        {
            var quotient = a / b;

            return quotient;
        }
        static public decimal Quotient(decimal a, decimal b)
        {
            var quotient = a / b;

            return quotient;
        }

        static public decimal Quotient(decimal[] doubleArray)
        {
            decimal result = 0;

            foreach (var x in doubleArray)
            {
                result = Quotient(result, x);
            }

            return result;
        }
        static public int Quotient(int[] doubleArray)
        {
            int result = 0;

            foreach (var x in doubleArray)
            {
                result = Quotient(result, x);
            }

            return result;
        }
    }
}
