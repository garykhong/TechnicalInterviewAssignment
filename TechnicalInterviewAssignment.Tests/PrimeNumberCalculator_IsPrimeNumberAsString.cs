using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class PrimeNumberCalculator_IsPrimeNumberAsString
    {
        [TestMethod]
        public void SampleTestCase_GivesExpectedResult()
        {            
            Assert.AreEqual(PrimeNumberCalculator.NotPrime, 
                IsPrimeNumberAsString(12));
            Assert.AreEqual(PrimeNumberCalculator.Prime,
                IsPrimeNumberAsString(5));
            Assert.AreEqual(PrimeNumberCalculator.Prime,
                IsPrimeNumberAsString(7));
            Assert.AreEqual(PrimeNumberCalculator.NotPrime,
               IsPrimeNumberAsString(1));
        }
        
        private string IsPrimeNumberAsString(int number)
        {
            PrimeNumberCalculator calculator =
                new PrimeNumberCalculator(number);
            return calculator.IsPrimeNumberAsString();
        }
    }
}
