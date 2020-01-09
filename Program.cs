using System;
using System.Collections.Generic;
using PrimeFactorsLib;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(int factor in PrimeFactorsHelper.PrimeFactors(1000))
            {
                Console.WriteLine(factor);
            }
        }
    }
}