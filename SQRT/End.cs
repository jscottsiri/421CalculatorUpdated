using System;
using MathOperations;

namespace SQRT
{
    class End : ISQRT
    {
        private dynamic Result;

        public dynamic SquareRoot(dynamic a)
        {
            Result = MathOperations.SquareRoot.End(a);
            return Result;
        }
    }
}
