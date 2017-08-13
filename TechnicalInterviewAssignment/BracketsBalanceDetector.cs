using System;
using System.Collections.Generic;

namespace TechnicalInterviewAssignment
{
    public class BracketsBalanceDetector
    {
        private string brackets;
        private List<BracketsSplitter> splitters;
        private List<BracketPairsCreator> pairsCreators;

        public BracketsBalanceDetector(string brackets)
        {
            this.brackets = brackets;
            splitters = new List<BracketsSplitter>();
            pairsCreators = new List<BracketPairsCreator>();
        }

        public bool AreBracketsBalanced()
        {
            SplitBrackets();
            SetPairsCreatorsFromSplitters();
            return AreBracketsEvenAmount() && AreBracketPairsAllMatching() && 
                     AreThereTheExpectedAmountOfBracketPairs();
        }

        private void SplitBrackets()
        {
            splitters.Add(new BracketsSplitter(brackets, "[", "]"));
            splitters.Add(new BracketsSplitter(brackets, "(", ")"));
            splitters.Add(new BracketsSplitter(brackets, "{", "}"));

            foreach (BracketsSplitter splitter in splitters)
                splitter.SplitBrackets();
        }

        private void SetPairsCreatorsFromSplitters()
        {
            pairsCreators = new List<BracketPairsCreator>();
            foreach (BracketsSplitter splitter in splitters)
            {
                pairsCreators.Add(new BracketPairsCreator(splitter.LeftBrackets,
                                         splitter.RightBrackets));
            }
        }

        private List<BracketPair> GetBracketPairs()
        {
            List<BracketPair> bracketpairs = new List<BracketPair>();
            foreach(BracketPairsCreator creator in pairsCreators)
            {
                foreach(BracketPair pair in creator.GetBracketPairs())
                {
                    bracketpairs.Add(pair);
                }
            }
            
            return bracketpairs;
        }

        private bool AreBracketsEvenAmount()
        {
            return brackets.Length % 2 == 0;
        }

        private bool AreThereTheExpectedAmountOfBracketPairs()
        {
            return GetBracketPairs().Count == brackets.Length / 2;
        }

        private bool AreBracketPairsAllMatching()
        {
            foreach (BracketPair bracketPair in GetBracketPairs())
            {
                BracketPairMatchDetector detector =
                    new BracketPairMatchDetector(bracketPair.FirstBracket, bracketPair.SecondBracket);
                if (!detector.AreBracketsAMatchingPair())
                {
                    return false;
                }
            }

            return true;
        }
        
    }
}
