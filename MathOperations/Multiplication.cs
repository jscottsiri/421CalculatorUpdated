using System;

namespace MathOperations
{
    public static class Multiplication : IMultiply
    {
        static public int Product(int a, int b)
        {
            var product = a * b;

            return product;
        }
        static public decimal Product(decimal a, decimal b)
        {
            var product = a * b;

            return product;
        }

        static public decimal Product(decimal[] doubleArray)
        {
            decimal result = 0;

            foreach (var x in doubleArray)
            {
                result = Product(result, x);
            }

            return result;
        }
        static public int Product(int[] doubleArray)
        {
            int result = 0;

            foreach (var x in doubleArray)
            {
                result = Product(result, x);
            }

            return result;
        }
    }
}
