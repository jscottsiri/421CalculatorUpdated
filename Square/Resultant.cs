using System;
using MathOperations;

namespace Square 
{
    class Resultant : ISquare
    {
        private dynamic Result;

        public dynamic Exponent(dynamic a, dynamic b)
        {
            Result = MathOperations.Exponent.Resultant(a, b);
            return Result;
        }
        public dynamic Exponent(dynamic arrayList)
        {
            Result = MathOperations.Exponent.Resultant(arrayList);
            return Result;
        }
    }
}
