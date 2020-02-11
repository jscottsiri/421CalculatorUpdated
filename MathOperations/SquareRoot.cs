using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations
{
    public static class SquareRoot : ISQRT
    {
        static public int End(int a)
        {
            var End = Math.Sqrt(a);

            return End;
        }
        static public decimal End(decimal a)
        {
            var End = Math.Sqrt(a);

            return End;
        }

    }
}
