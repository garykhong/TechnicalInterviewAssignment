using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class BracketsSplitter_SplitBrackets
    {
        BracketsSplitter splitter;

        [TestMethod]
        public void EightBrackets_GetsSplitIntoTwoListsWithLengthOfFour()
        {
            string brackets = "[[[[]]]]";
            SplitBrackets(brackets, "[", "]");
            Assert.AreEqual(4, splitter.LeftBrackets.Count);
            Assert.AreEqual(4, splitter.RightBrackets.Count);
        }

        [TestMethod]
        public void SevenBrackets_FirstListGetsLengthOfFourSecondListGetsLengthOfThree()
        {
            string brackets = "[[[[]]]";
            SplitBrackets(brackets, "[", "]");
            Assert.AreEqual(4, splitter.LeftBrackets.Count);
            Assert.AreEqual(3, splitter.RightBrackets.Count);
        }

        private void SplitBrackets(string brackets, string leftBracket, string rightBracket)
        {
            splitter = new BracketsSplitter(brackets, leftBracket, rightBracket);
            splitter.SplitBrackets();
        }
    }
}
