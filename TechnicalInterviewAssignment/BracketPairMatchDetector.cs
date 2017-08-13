using System;
using System.Collections.Generic;

namespace TechnicalInterviewAssignment
{
    public class BracketPairMatchDetector
    {
        private Bracket firstBracket;
        private Bracket secondBracket;

        public BracketPairMatchDetector(Bracket firstBracket, Bracket secondBracket)
        {
            this.firstBracket = firstBracket;
            this.secondBracket = secondBracket;
        }

        public bool AreBracketsAMatchingPair()
        {
            if(secondBracket.Index > firstBracket.Index)
            {
                switch (firstBracket.Value)
                {
                    case "(":
                        return secondBracket.Value == ")";
                    case "[":
                        return secondBracket.Value == "]";
                    case "{":
                        return secondBracket.Value == "}";
                }
            }            

            return false;
        }
    }
}
