using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class RunningMedianCalculator_GetRunningMedian
    {
        [TestMethod]
        public void SampleTestCase_GivesExpectedResult()
        {
            RunningMedianCalculator calculator = new RunningMedianCalculator();
            calculator.AddNumber(12);
            Assert.AreEqual(12.0D, GetRunningMedian(calculator));
            calculator.AddNumber(4);
            Assert.AreEqual(8.0D, GetRunningMedian(calculator));
            calculator.AddNumber(5);
            Assert.AreEqual(5.0D, GetRunningMedian(calculator));
            calculator.AddNumber(3);
            Assert.AreEqual(4.5D, GetRunningMedian(calculator));
            calculator.AddNumber(8);
            Assert.AreEqual(5D, GetRunningMedian(calculator));
            calculator.AddNumber(7);
            Assert.AreEqual(6D, GetRunningMedian(calculator));
        }        

        private double GetRunningMedian(RunningMedianCalculator calculator)
        {            
            return calculator.GetRunningMedian();
        }
    }
}
