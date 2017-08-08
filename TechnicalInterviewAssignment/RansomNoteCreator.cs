using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace TechnicalInterviewAssignment
{
    public class RansomNoteCreator
    {
        private string[] MagazineWords { get; set; }
        private string[] IntendedRansomNoteWords { get; set; }

        public RansomNoteCreator(string[] magazineWords, string[] intendedRansomNoteWords)
        {
            MagazineWords = magazineWords;
            IntendedRansomNoteWords = intendedRansomNoteWords;
        }         

        public bool CanCreateRansomNote()
        {
            Array.Sort(MagazineWords);
            Array.Sort(IntendedRansomNoteWords);

            Dictionary<int, string> magazineWordsDictionary = 
                MagazineWords.Select((word, index) => new { Word = word, Index = index}).
                 ToDictionary(wordKeyValuePair => wordKeyValuePair.Index, 
                                  wordKeyValuePair => wordKeyValuePair.Word);
            
            for(int index = 0; index < IntendedRansomNoteWords.Count(); index++)
            {
                KeyValuePair<int, string> intendedRansomNoteWordKeyValuePair =
                    magazineWordsDictionary.
                      FirstOrDefault(wordKeyValuePair => 
                          wordKeyValuePair.Value.Equals(IntendedRansomNoteWords[index]));

                if (intendedRansomNoteWordKeyValuePair.Equals(new KeyValuePair<int, string>()))
                {
                    return false;
                }
                else
                {
                    magazineWordsDictionary.Remove(intendedRansomNoteWordKeyValuePair.Key);                    
                }                
            }
            return true;
        }
    }
}
