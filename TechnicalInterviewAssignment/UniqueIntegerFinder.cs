using System;
using System.Collections.Generic;

namespace TechnicalInterviewAssignment
{
    public class UniqueIntegerFinder
    {
        private int[] Numbers { get; set; }
        public UniqueIntegerFinder(int[] numbers)
        {
            Numbers = numbers;
        }

        public int GetUniqueInteger()
        {
            List<int> numbersList = new List<int>(Numbers);
            foreach(int number in numbersList)
            {
                if (numbersList.FindAll(numberInList => 
                                number == numberInList).Count == 1)
                    return number;
            }            

            return 0;
        }        
    }
}
