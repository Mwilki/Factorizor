using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Compatibility;
using Factorizor.BLL;
using NUnit.Framework;

namespace Factorizor.Tests
{
    public class FactorizerTest
    {
        [TestCase("10", "2, 5")]
        [TestCase("12", "2, 3, 4, 6")]
        [TestCase("22", "2, 11")]
        [TestCase("50", "2, 5, 10, 25")]
        [TestCase("472", "2, 4, 8, 59, 118, 236")]

        public void NumberReturnsFactors(string number, string output)
        {
            FactorFinder find = new FactorFinder();
            string actual = find.PrintFactors(number);

            Assert.AreEqual(output, actual);
        }

        [TestCase("6", true)]
        [TestCase("28", true)]
        [TestCase("22", false)]
        [TestCase("496", true)]

        public void NumberIsPerfect(string number, bool output)
        {
            PerfectChecker find = new PerfectChecker();
            bool actual = find.IsPerfect(number);

            Assert.AreEqual(output, actual);
        }

        [TestCase("2", true)]
        [TestCase("3", true)]
        [TestCase("13", true)]
        [TestCase("15", false)]
        [TestCase("29", true)]
        [TestCase("152", false)]
        [TestCase("199", true)]
        public void NumberIsPrime(string number, bool output)
        {
            PrimeFinder find = new PrimeFinder();
            bool actual = find.PrimeChecker(number);

            Assert.AreEqual(output, actual);
        }
    }
}
