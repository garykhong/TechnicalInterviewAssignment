using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class BracketsBalanceDetector_AreBracketsBalanced
    {
        [TestMethod]
        public void EightLengthBalancedBrackets_GivesTrue()
        {            
            Assert.AreEqual(true, 
                AreBracketsBalanced("[[[[]]]]"));
        }

        [TestMethod]
        public void FourLengthBalancedMixedBrackets_GivesTrue()
        {
            Assert.AreEqual(true,
                AreBracketsBalanced("[[]]"));
        }

        [TestMethod]
        public void SevenLengthBrackets_GivesFalse()
        {
            Assert.AreEqual(false,
                AreBracketsBalanced("[[[[]]]"));
        }

        [TestMethod]
        public void EightLengthNonBalancedBrackets_GivesFalse()
        {
            Assert.AreEqual(false,
                AreBracketsBalanced("[[[{]]]]"));
        }

        [TestMethod]
        public void TestCaseZero_MatchExpectedOutput()
        {
            Assert.AreEqual(false,
                AreBracketsBalanced("}][}}(}][))]"));
            Assert.AreEqual(true,
                AreBracketsBalanced("[](){()}"));
            Assert.AreEqual(true,
                AreBracketsBalanced("()"));
            Assert.AreEqual(true,
                AreBracketsBalanced("({}([][]))[]()"));
            Assert.AreEqual(false,
                AreBracketsBalanced("{)[](}]}]}))}(())("));
        }

        [TestMethod]
        public void SampleTestCase_MatchExpectedOutput()
        {
            Assert.AreEqual(true, AreBracketsBalanced("{[()]}"));
            Assert.AreEqual(false, AreBracketsBalanced("{[(])}"));
            Assert.AreEqual(true, AreBracketsBalanced("{{[[(())]]}}"));
        }

        private bool AreBracketsBalanced(string brackets)
        {
            BracketsBalanceDetector detector =
                new BracketsBalanceDetector(brackets);
            return detector.AreBracketsBalanced();
        }
    }
}
