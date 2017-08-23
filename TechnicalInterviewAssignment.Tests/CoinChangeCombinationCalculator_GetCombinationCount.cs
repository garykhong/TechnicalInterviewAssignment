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
                GetCombinationCount(10, new int[] { 2, 3, 5, 6 }));
        }        

        private int GetCombinationCount(int moneyToBreak, int[] changeDollars)
        {
            CoinChangeCombinationCalculator calculator = 
                new CoinChangeCombinationCalculator(moneyToBreak, changeDollars);
            return calculator.GetCombinationCount();
        }
    }
}
