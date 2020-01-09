using Xunit;
using PrimeFactorsLib;
using System.Collections.Generic;

namespace PrimeFactorsTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test10()
        {
            var factors = PrimeFactorsHelper.PrimeFactors(10);
            Assert.True(Product(factors) == 10);
        }

        [Fact]
        public void Test1000()
        {
            var factors = PrimeFactorsHelper.PrimeFactors(1000);
            Assert.True(Product(factors) == 1000);
        }

        [Theory]
        [InlineData(3, 3)]
        [InlineData(5, 5)]
        [InlineData(9, 9)]
        [InlineData(1000, 1000)]
        public void TestProductCalculation(int leafLeft, int leafRight)
        {
            var factors = new List<int>(){ leafLeft, leafRight };
            Assert.True(Product(factors) == leafLeft * leafRight);
        }

        public int Product(List<int> primes)
        {
            int product = 1;

            foreach(int prime in primes)
            {
                product *= prime;
            }

            return product;
        }
    }
}
