using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class UniqueIntegerFinder_GetUniqueInteger
    {
        [TestMethod]
        public void Numbers11223_Gives3()
        {            
            Assert.AreEqual(3, 
                GetUniqueInteger(new int[] { 1, 1, 2, 2, 3 }));
        }

        [TestMethod]
        public void Numbers224455066_Gives0()
        {
            Assert.AreEqual(0,
                GetUniqueInteger(new int[] { 2, 2, 4, 4, 5, 5, 0, 6, 6 }));
        }

        private int GetUniqueInteger(int[] numbers)
        {
            UniqueIntegerFinder uniqueIntegerFinder =
                new UniqueIntegerFinder(numbers);
            return uniqueIntegerFinder.GetUniqueInteger();
        }
    }
}
