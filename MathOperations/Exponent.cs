using System;

namespace MathOperations
{
    public static class Exponent : ISquare
    {
        static public int Resultant(int a, int b)
        {
            var resultant = a ** b;

            return resultant;
        }
        static public decimal Resultant(decimal a, decimal b)
        {
            var quotient = a ** b;

            return resultant;
        }

        static public decimal Resultant(decimal[] doubleArray)
        {
            decimal result = 0;

            foreach (var x in doubleArray)
            {
                result = Resultant(result, x);
            }

            return result;
        }
        static public int Resultant(int[] doubleArray)
        {
            int result = 0;

            foreach (var x in doubleArray)
            {
                result = Resultant(result, x);
            }

            return result;
        }
    }
}
