using System;
using System.Collections.Generic;
using System.Linq;

namespace TechnicalInterviewAssignment
{
    public class AnagramDetector
    {
        private string FirstString { get; set; }
        private string SecondString { get; set; }
        
        public AnagramDetector(string firstString, string secondString)
        {
            FirstString = firstString;
            SecondString = secondString;
        }

        public int GetCharacterDeleteCountToMakeAnagram()
        {
            foreach(char firstStringChar in FirstString)
            {
                if(SecondString.IndexOf(firstStringChar) >= 0)
                {
                    FirstString = FirstString.Remove(FirstString.IndexOf(firstStringChar), 1);
                    SecondString = SecondString.Remove(SecondString.IndexOf(firstStringChar), 1);
                }
            }

            return FirstString.Length + SecondString.Length;
        }       
        
    }
}
