using System;

namespace TechnicalInterviewAssignment
{
    public class StringReverser
    {
        public string ReverseString(string stringToReverse)
        {
            string reversedString = string.Empty;
            
            for(int characterIndex = 0; characterIndex < stringToReverse.Length; characterIndex++)
            {
                reversedString += 
                    stringToReverse.ToCharArray()[stringToReverse.Length - (characterIndex + 1)];
            }               

            return reversedString;
        }
    }
}
