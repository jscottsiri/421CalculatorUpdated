using System;

namespace MathOperations
{
    public static class Subtraction
    {
        static public int Result(int a, int b)
        {
            var c = a - b;

            return c;
        }
        static public decimal Result(decimal a, decimal b)
        {
            var result = a - b;

            return result;
        }

        static public decimal Result(decimal a ,decimal[] doubleArray)
        {
            decimal result = a;

            foreach (var x in doubleArray)
            {
                result = Result(result, x);
            }

            return result;
        }
        static public int Result(int a, int[] doubleArray)
        {
            int result = a;

            foreach (var x in doubleArray)
            {
                result = Result(result, x);
            }

            return result;
        }
    }
}
