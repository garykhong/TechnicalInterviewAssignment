using System;
using System.Collections.Generic;

namespace TechnicalInterviewAssignment
{
    public class RunningMedianCalculator
    {
        private List<int> numbers = new List<int>();
        private int numbersCount = 0;

        public void AddNumber(int numberToAdd)
        {
            numbersCount = numbers.Count;
            if(numbers.Count == 0)
            {
                numbers.Add(numberToAdd);
            }
            else
            {
                TryToPushNumberUp(numberToAdd);
                if(!HasNumbersIncreasedByOne())
                {
                    TryToPushNumberDown(numberToAdd);
                }                
            }            
        }

        private bool HasNumbersIncreasedByOne()
        {
            return numbers.Count == numbersCount + 1;            
        }

        private void TryToPushNumberUp(int numberToAdd)
        {
            int index = 0;
            foreach(int number in numbers)
            {
                if(numberToAdd <= number)
                {
                    numbers.Insert(index, numberToAdd);
                    return;
                }
                index++;
            }
        }

        private void TryToPushNumberDown(int numberToAdd)
        {
            int index = 0;
            int lastIndexNumberToAddWasGreaterThanExistingNumber = -1;
            while(numberToAdd > numbers[index] && index < numbers.Count)
            {
                lastIndexNumberToAddWasGreaterThanExistingNumber = index;
                index++;
            }

            if(lastIndexNumberToAddWasGreaterThanExistingNumber >= 0)
            {
                numbers.Insert(lastIndexNumberToAddWasGreaterThanExistingNumber, numberToAdd);
            }
        }

        public double GetRunningMedian()
        {
            double runningMedian = 0;
            int middleIndex = numbers.Count / 2;            

            if (numbers.Count % 2 == 0)
            {
                if (middleIndex > 0)
                {
                    middleIndex -= 1;
                }
                runningMedian = ((double)numbers[middleIndex] + (double)numbers[middleIndex + 1]) / 2;
            }
            else
            {                
                runningMedian = numbers[middleIndex];
            }

            return Math.Round(runningMedian, 1);
        }
    }
}
