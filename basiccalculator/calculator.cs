using System;
using MathOperations;
using Addition;
using Subtraction;
using Multiplication;
namespace basiccalculator
{
    public class Calculator : IAdd, ISubtract, IMultiply, IDivide, ISquare, ISQRT
    {
        private dynamic _result;

        public dynamic Result
        {
            get => _result;
            set => _result = value;
        }

        Adding Addition = new Adding();
        Difference Subtraction = new Difference();
        Product Multiplication = new Product();
        Quotient Division = new Quotient();
        Resultant Exponent = new Resultant();
        End SquareRoot = new End();

        public dynamic Sum(dynamic a, dynamic b)
        {
            Result = Addition.Sum(a, b);
            return Result;

        }
        public dynamic Sum(dynamic arrayList)
        {
            Result = Addition.Sum(arrayList);
            return Result;
        }

        public int Subtract(int a, int b)
        {
            Result = Subtraction.Subtract(a, b);
            return Result;

        }
        public dynamic Product(dynamic a, dynamic b)
        {
            Result = Multiplication.Product(a, b);
            return Result;
        }
        public dynamic Product(dynamic arrayList)
        {
            Result = Multiplication.Product(arrayList);
            return Result;
        }
        public dynamic Quotient(dynamic a, dynamic b)
        {
            Result = Division.Quotient(a, b);
            return Result;
        }
        public dynamic Quotient(dynamic arrayList)
        {
            Result = Division.Quotient(arrayList);
            return Result;
        }
        public dynamic Resultant(dynamic a, dynamic b)
        {
            Result = Exponent.Resultant(a,b);
            return Result;
        }
        public dynamic Resultant(dynamic arrayList)
        {
            Result = Exponent.Resultant(arrayList);
            return Result;
        }
        public dynamic End(dynamic a)
        {
            Result = SquareRoot.End(a);
            return Result;
        }
    }
}
