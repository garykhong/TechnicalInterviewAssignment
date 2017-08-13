using System;
using System.Collections.Generic;

namespace TechnicalInterviewAssignment
{
    public class BracketsBalanceDetector
    {
        private string brackets;        
        private Stack<BracketPair> leftBrackets;

        public BracketsBalanceDetector(string brackets)
        {
            this.brackets = brackets;            
            leftBrackets = new Stack<BracketPair>();
        }

        public bool AreBracketsBalanced()
        {            
            foreach(char bracket in brackets)
            {
                switch(bracket)
                {
                    case '[':
                        leftBrackets.Push(new BracketPair(new Bracket("[", 0), new Bracket("]", 0)));
                        break;
                    case '(':
                        leftBrackets.Push(new BracketPair(new Bracket("(", 0), new Bracket(")", 0)));
                        break;
                    case '{':
                        leftBrackets.Push(new BracketPair(new Bracket("{", 0), new Bracket("}", 0)));
                        break;
                    default:
                        if(leftBrackets.Count == 0)
                        {
                            return false;
                        }
                        else
                        {
                            var leftBracket = leftBrackets.Pop();
                            if(leftBracket.SecondBracket.Value != bracket.ToString())
                            {
                                return false;
                            }
                        }

                        break;
                }
            }
            return AreBracketsEvenAmount() && leftBrackets.Count == 0;
        }        

        private bool AreBracketsEvenAmount()
        {
            return brackets.Length % 2 == 0;
        }       
    }
}
