using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;
using System.Collections.Generic;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class BracketPairsCreator_GetBracketPairs
    {
        private BracketsSplitter splitter;
        [TestMethod]
        public void FourBracketStackFourBracketQueue_GivesOneBracketPairs()
        {
            List<BracketPair> bracketPairs = GetBracketPairs("[([{}])]");
            Assert.AreEqual(2, bracketPairs.Count);
            Assert.AreEqual("[]", bracketPairs[0].ToString());
        }

        [TestMethod]
        public void FiveBracketStackFourBracketQueue_GivesOneBracketPairs()
        {
            List<BracketPair> bracketPairs = GetBracketPairs("[([{(}])]");
            Assert.AreEqual(2, bracketPairs.Count);
            Assert.AreEqual("[]", bracketPairs[0].ToString());
        }        

        private List<BracketPair> GetBracketPairs(string brackets)
        {
            splitter = new BracketsSplitter(brackets, "[", "]");
            splitter.SplitBrackets();
            BracketPairsCreator creator = new BracketPairsCreator(splitter.LeftBrackets, 
                                                                   splitter.RightBrackets);
            return creator.GetBracketPairs();
        }
    }
}
