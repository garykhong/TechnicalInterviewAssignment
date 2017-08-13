using System;
using System.Collections.Generic;

namespace TechnicalInterviewAssignment
{
    public class BracketPairsCreator
    {
        private List<Bracket> firstHalfOfBrackets;
        private List<Bracket> secondHalfOfBrackets;

        public BracketPairsCreator(List<Bracket> firstHalfOfBrackets, List<Bracket> secondHalfOfBrackets)
        {
            this.firstHalfOfBrackets = firstHalfOfBrackets;
            this.secondHalfOfBrackets = secondHalfOfBrackets;
        }

        public List<BracketPair> GetBracketPairs()
        {          

            List<BracketPair> bracketPairs = new List<BracketPair>();
            int bracketPairsCount = firstHalfOfBrackets.Count;

            for(int index = 0; index < bracketPairsCount; index++)
            {
                if(secondHalfOfBrackets.Count > 0)
                {
                    bracketPairs.Add(new BracketPair(firstHalfOfBrackets[index], 
                        secondHalfOfBrackets[index]));
                }
                else
                {
                    bracketPairs.Add(new BracketPair(firstHalfOfBrackets[index], 
                        new Bracket(string.Empty, 100)));
                }                
            }

            return bracketPairs;
        }
    }
}
