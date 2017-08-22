using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class StaircaseStepCombinationCalculator_GetCombinationCount
    {
        [TestMethod]
        public void SampleTestCase_GivesExpectedResults()
        {            
            Assert.AreEqual(1, 
                GetCombinationCount(1));
            Assert.AreEqual(2,
                GetCombinationCount(2));
            Assert.AreEqual(4,
                GetCombinationCount(3));
            Assert.AreEqual(7,
                GetCombinationCount(4));
            Assert.AreEqual(13,
                GetCombinationCount(5));
            Assert.AreEqual(24,
                GetCombinationCount(6));
            Assert.AreEqual(44,
                GetCombinationCount(7));
            Assert.AreEqual(1132436852,
                GetCombinationCount(35));
        }

        private int GetCombinationCount(int steps)
        {
            StaircaseStepCombinationCalculator calculator =
                new StaircaseStepCombinationCalculator(steps);
            return calculator.GetCombinationCount();
        }
    }
}
