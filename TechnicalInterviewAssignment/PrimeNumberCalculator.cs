using System;
using System.Collections.Generic;

namespace TechnicalInterviewAssignment
{
    public class PrimeNumberCalculator
    {
        public static string NotPrime = "Not prime";
        public static string Prime = "Prime";
        private int number;

        public PrimeNumberCalculator(int number)
        {
            this.number = number;
        }

        public string IsPrimeNumberAsString()
        {
            return IsPrimeNumber() ? Prime : NotPrime;
        }

        private bool IsPrimeNumber()
        {
            if (number == 1)
                return false;

            int index = 0;

            for (index = GetStartingIndex(); index < Math.Sqrt(number); index += 2)
            {
                if (number % index == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private int GetStartingIndex()
        {
            if(number % 2 == 0)
            {
                return 2;
            }

            return 3;
        }
    }
}
