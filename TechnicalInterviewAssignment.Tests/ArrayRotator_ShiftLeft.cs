using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class ArrayRotator_ShiftLeft
    {
        [TestMethod]
        public void Shift5By4TimesIn12345_Gives51234()
        {
            int numberToShift = 5;
            int numberOfTimesToShift = 4;
            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] expectedShiftedNumbers = { 5, 1, 2, 3, 4 };

            ArrayRotator arrayRotator = new ArrayRotator(numberToShift, 
                                                     numberOfTimesToShift, numbers);
            int[] shiftedNumbers = arrayRotator.ShiftLeft();
            CollectionAssert.AreEqual(expectedShiftedNumbers, shiftedNumbers);
        }

        [TestMethod]
        public void Shift5By1TimesIn12345_Gives23451()
        {
            int numberToShift = 5;
            int numberOfTimesToShift = 1;
            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] expectedShiftedNumbers = { 2, 3, 4, 5, 1 };

            ArrayRotator arrayRotator = new ArrayRotator(numberToShift,
                                                     numberOfTimesToShift, numbers);
            int[] shiftedNumbers = arrayRotator.ShiftLeft();
            CollectionAssert.AreEqual(expectedShiftedNumbers, shiftedNumbers);
        }
    }
}
