using System;
using System.Collections.Generic;
using System.Linq;

namespace TechnicalInterviewAssignment
{
    public class BracketsSplitter
    {
        private string brackets;
        private string leftBracketToSearchFor;
        private string rightBracketToSearchFor;

        public BracketsSplitter(string brackets, 
                                 string leftBracketToSearchFor, 
                                   string rightBracketToSearchFor)
        {
            this.brackets = brackets;
            LeftBrackets = new List<Bracket>();
            RightBrackets = new List<Bracket>();
            this.leftBracketToSearchFor = leftBracketToSearchFor;
            this.rightBracketToSearchFor = rightBracketToSearchFor;
        }

        public List<Bracket> LeftBrackets { get; set; }
        public List<Bracket> RightBrackets { get; set; }

        public void SplitBrackets()
        {          
            LeftBrackets = GetBrackets(leftBracketToSearchFor);
            RightBrackets = GetBrackets(rightBracketToSearchFor);
        }     

        private int GetHalfOfBracketsLength()
        {
            return
                brackets.Length % 2 == 0 ?
                  brackets.Length / 2 : brackets.Length / 2 + 1;
        }

        public List<Bracket> GetBrackets(string bracketToSearchFor)
        {
            List<Bracket> bracketsFound = new List<Bracket>();

            for(int index = 0; index < brackets.Length; index++)
            {
                if(brackets[index].ToString() == bracketToSearchFor)
                    bracketsFound.Add(new Bracket(brackets[index].ToString(), index));
            }

            return bracketsFound;
        }
    }
}
