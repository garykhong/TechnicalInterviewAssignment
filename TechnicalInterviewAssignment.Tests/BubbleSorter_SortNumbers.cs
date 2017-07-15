using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class BubbleSorter_SortNumbers
    {
        [TestMethod]
        public void Input123NumbersArray_Gives0SwapsAnd123NumbersArray()
        {
            BubbleSorter bubbleSorter = new BubbleSorter(new int[] { 1, 2, 3 });
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, bubbleSorter.SortNumbers());
            Assert.AreEqual(0, bubbleSorter.NumberOfSwaps);
        }

        [TestMethod]
        public void Input321NumbersArray_Gives3SwapsAnd123NumbersArray()
        {
            BubbleSorter bubbleSorter = new BubbleSorter(new int[] { 3, 2, 1 });
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, bubbleSorter.SortNumbers());
            Assert.AreEqual(3, bubbleSorter.NumberOfSwaps);
        }
    }
}
