using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Return an array listing the prime factors of the number passed in.
        /// </summary>
        /// <param name="numberIn"></param>
        /// <returns></returns>
        public static List<int> PrimeFactors(int composite)
        {
            var primeFactors = new List<int>();
            int divisor = 2;
            int leafLeft = composite;
            int leafRight = 0;

            while (divisor < leafLeft)
            {
                if (leafLeft % divisor == 0)
                {
                    leafLeft = leafLeft / divisor;
                    leafRight = divisor;
                    primeFactors.Add(leafRight);
                    primeFactors.Add(leafRight);
                    break;
                }
                else
                {
                    divisor++;
                }
            }

            return primeFactors;
        }

        public static bool IsPrime(int numberIn)
        {
            return true;
        }
    }
}