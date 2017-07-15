using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class StringReverser_ReverseString
    {
        [TestMethod]
        public void ABC_GivesCBA()
        {
            StringReverser stringReverser = new StringReverser();
            string reversedString = stringReverser.ReverseString("ABC");
            Assert.AreEqual("CBA", reversedString);
        }

        [TestMethod]
        public void Blank_GivesBlank()
        {
            StringReverser stringReverser = new StringReverser();
            string reversedString = stringReverser.ReverseString(string.Empty);
            Assert.AreEqual(string.Empty, reversedString);
        }
    }
}
