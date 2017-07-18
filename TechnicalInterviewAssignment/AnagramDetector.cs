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
            string firstStringToDeleteCommonCharactersFrom = FirstString;
            string secondStringToDeleteCommonCharactersFrom = SecondString;
            foreach(char firstStringChar in firstStringToDeleteCommonCharactersFrom)
            {
                if(secondStringToDeleteCommonCharactersFrom.
                    IndexOf(firstStringChar) >= 0)
                {
                    firstStringToDeleteCommonCharactersFrom =
                        RemoveFirstMatchingCharacterFromString(
                            firstStringToDeleteCommonCharactersFrom,
                            firstStringChar);

                    secondStringToDeleteCommonCharactersFrom =
                        RemoveFirstMatchingCharacterFromString(
                            secondStringToDeleteCommonCharactersFrom,
                            firstStringChar);
                }
            }

            return firstStringToDeleteCommonCharactersFrom.Length + 
                secondStringToDeleteCommonCharactersFrom.Length;
        } 
        
        private string RemoveFirstMatchingCharacterFromString(
            string stringToRemoveCharacter, char characterToRemove)
        {
            return stringToRemoveCharacter.Remove(
                            stringToRemoveCharacter.IndexOf(characterToRemove), 1);
        }
        
    }
}
