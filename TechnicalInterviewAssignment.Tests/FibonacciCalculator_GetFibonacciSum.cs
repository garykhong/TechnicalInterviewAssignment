using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class FibonacciCalculator_GetFibonacciSum
    {

        [TestMethod]
        public void MaximumIndexOf0_Gives0()
        {            
            Assert.AreEqual(0, GetFibonacciSum(0));
        }

        [TestMethod]
        public void MaximumIndexOf1_Gives1()
        {
            Assert.AreEqual(1, GetFibonacciSum(1));
        }

        [TestMethod]
        public void MaximumIndexOf2_Gives1()
        {
            Assert.AreEqual(1, GetFibonacciSum(2));
        }

        [TestMethod]
        public void MaximumIndexOf3_Gives2()
        {
            Assert.AreEqual(2, GetFibonacciSum(3));
        }

        [TestMethod]
        public void MaximumIndexOf6_Gives8()
        {
            Assert.AreEqual(8, GetFibonacciSum(6));
        }

        private int GetFibonacciSum(int maximumIndex)
        {
            FibonacciCalculator fibonacciCalculator = new FibonacciCalculator(maximumIndex);
            return fibonacciCalculator.GetFibonacciSum();
        }
    }
}
