using System;
using System.Collections.Generic;
using System.Linq;

namespace TechnicalInterviewAssignment
{
    public class CoinChangeCombinationCalculator
    {
        private int moneyToBreak;
        private int[] changeDollars;

        public CoinChangeCombinationCalculator(int moneyToBreak, int[] changeDollars)
        {
            this.moneyToBreak = moneyToBreak;
            this.changeDollars = changeDollars;
        }        

        public int GetCombinationCount(int changeDollarsIndex, Dictionary<string, int> changeCombinations)
        {
            int runningTotal = 0;
            int combinations = 0;

            if(moneyToBreak == 0)
            {
                return 1;
            }

            if(changeDollarsIndex >= changeDollars.Length)
            {
                return 0;
            }

            string key = moneyToBreak.ToString() + "-" + changeDollarsIndex.ToString();

            if(changeCombinations.ContainsKey(key))
            {
                return changeCombinations[key];
            }

            while(runningTotal <= moneyToBreak)
            {
                int remainingTotal = moneyToBreak - runningTotal;
                combinations += new CoinChangeCombinationCalculator(remainingTotal, changeDollars).
                                                          GetCombinationCount(changeDollarsIndex + 1, 
                                                                               changeCombinations);
                runningTotal += changeDollars[changeDollarsIndex];
            }

            changeCombinations.Add(key, combinations);

            return combinations;
        }
    }
}
