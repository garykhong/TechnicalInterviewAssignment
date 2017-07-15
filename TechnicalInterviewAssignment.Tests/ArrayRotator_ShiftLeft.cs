using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class ArrayRotator_ShiftLeft
    {
        private int numberToShift;
        private int numberOfTimesToShift;
        private int[] numbers;
        private int[] expectedShiftedNumbers;

        [TestMethod]
        public void Shift5By4TimesIn12345_Gives51234()
        {
            numberToShift = 5;
            numberOfTimesToShift = 4;
            numbers = new int[] { 1, 2, 3, 4, 5 };
            expectedShiftedNumbers = new int[] { 5, 1, 2, 3, 4 };            
            CollectionAssert.AreEqual(expectedShiftedNumbers, GetShiftedLeftNumbers());
        }

        [TestMethod]
        public void Shift5By1TimesIn12345_Gives23451()
        {
            numberToShift = 5;
            numberOfTimesToShift = 1;
            numbers = new int[] { 1, 2, 3, 4, 5 };
            expectedShiftedNumbers = new int[] { 2, 3, 4, 5, 1 };            
            CollectionAssert.AreEqual(expectedShiftedNumbers, GetShiftedLeftNumbers());
        }

        [TestMethod]
        public void Shift5By2TimesIn12345_Gives34512()
        {
            numberToShift = 5;
            numberOfTimesToShift = 2;
            numbers = new int[] { 1, 2, 3, 4, 5 };
            expectedShiftedNumbers = new int[] { 3, 4, 5, 1, 2 };
            CollectionAssert.AreEqual(expectedShiftedNumbers, GetShiftedLeftNumbers());
        }

        [TestMethod]
        public void Shift5By3TimesIn12345_Gives45123()
        {
            numberToShift = 5;
            numberOfTimesToShift = 3;
            numbers = new int[] { 1, 2, 3, 4, 5 };
            expectedShiftedNumbers = new int[] { 4, 5, 1, 2, 3 };
            CollectionAssert.AreEqual(expectedShiftedNumbers, GetShiftedLeftNumbers());
        }

        private int[] GetShiftedLeftNumbers()
        {
            ArrayRotator arrayRotator = new ArrayRotator(numberToShift,
                                                     numberOfTimesToShift, numbers);
            return arrayRotator.ShiftLeft();
        }
    }
}
