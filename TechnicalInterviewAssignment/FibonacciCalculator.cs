using System;

namespace TechnicalInterviewAssignment
{
    public class FibonacciCalculator
    {
        private int MaximumIndex { get; set; }
        private int[] fibonnaciNumbers;
        public FibonacciCalculator(int maximumIndex)
        {
            MaximumIndex = maximumIndex;
            fibonnaciNumbers = new int[maximumIndex + 1];
        }

        public int GetFibonacciSum()
        {
            SetFibonacciNumbers();
            return fibonnaciNumbers[MaximumIndex];
        }

        private void SetFibonacciNumbers()
        {
            for (int index = 0; index < fibonnaciNumbers.Length; index++)
            {
                fibonnaciNumbers[index] = GetFibonacciNumber(index);
            }
        }

        private int GetFibonacciNumber(int index)
        {
            int fibonacciNumber = 0;
            if (index >= 2)
            {
                fibonacciNumber = fibonnaciNumbers[index - 1] +
                                            fibonnaciNumbers[index - 2];
            }
            else
            {
                fibonacciNumber = index;
            }

            return fibonacciNumber;
        }
    }
}
