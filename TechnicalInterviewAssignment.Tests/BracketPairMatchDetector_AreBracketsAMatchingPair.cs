using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class BracketPairMatchDetector_AreBracketsAMatchingPair
    {
        [TestMethod]
        public void LeftSquareBracketRightSquareBracket_GivesTrue()
        {            
            Assert.AreEqual(true, 
                AreBracketsAMatchingPair("[", "]"));
        }

        [TestMethod]
        public void LeftCurvedBracketRightCurvedBracket_GivesTrue()
        {
            Assert.AreEqual(true,
                AreBracketsAMatchingPair("(", ")"));
        }

        [TestMethod]
        public void LeftSquigglyBracketRightSquigglyBracket_GivesTrue()
        {
            Assert.AreEqual(true,
                AreBracketsAMatchingPair("{", "}"));
        }

        [TestMethod]
        public void RightSquigglyBracketLeftSquigglyBracket_GivesFalse()
        {
            Assert.AreEqual(false,
                AreBracketsAMatchingPair("}", "{"));
        }

        [TestMethod]
        public void LeftSquareBracketRightSquigglyBracket_GivesFalse()
        {
            Assert.AreEqual(false,
                AreBracketsAMatchingPair("[", "}"));
        }

        private bool AreBracketsAMatchingPair(string firstBracket, string secondBracket)
        {
            BracketPairMatchDetector detector = 
                new BracketPairMatchDetector(new Bracket(firstBracket, 0), new Bracket(secondBracket, 1));
            return detector.AreBracketsAMatchingPair();
        }
    }
}
