using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class CoinChangeCombinationCalculator_GetCombinationCount
    {
        [TestMethod]
        public void SampleTestCase_GivesExpectedOutput()
        {
            Assert.AreEqual(4, 
                GetCombinationCount(4, new int[] { 1, 2, 3 }));
            Assert.AreEqual(5,
                GetCombinationCount(10, new int[] { 2, 5, 3, 6 }));
        }

        [TestMethod]
        public void TestCase2_GivesExpectedOutput()
        {
            Assert.AreEqual(96190959,
                GetCombinationCount(166, new int[] { 5, 37, 8, 39, 33, 17, 22, 32, 13, 7, 10, 35, 40, 2, 43, 49, 46, 19, 41, 1, 12, 11, 28}));            
        }

        private int GetCombinationCount(int moneyToBreak, int[] changeDollars)
        {
            CoinChangeCombinationCalculator calculator = 
                new CoinChangeCombinationCalculator(moneyToBreak, changeDollars);
            return calculator.GetCombinationCount(0, new System.Collections.Generic.Dictionary<string, int>());
        }
    }
}
