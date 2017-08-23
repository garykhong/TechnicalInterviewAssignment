using System;
using System.Collections.Generic;
using System.Linq;

namespace TechnicalInterviewAssignment
{
    public class CoinChangeCombinationCalculator
    {
        private int moneyToBreak;
        private int[] changeToGiveInDollars;
        private Dictionary<string, string> changeCombinations = new Dictionary<string, string>();
        private int runningTotal;
        private List<int> changeCombination;

        public CoinChangeCombinationCalculator(int moneyToBreak, int[] changeToGiveInDollars)
        {
            this.moneyToBreak = moneyToBreak;
            this.changeToGiveInDollars = changeToGiveInDollars;
            this.changeCombination = new List<int>();
        }

        public int GetCombinationCount()
        {
            SetCombinationCount();
            return changeCombinations.Count;
        }

        public void SetCombinationCount()
        {
            
            foreach(int changeAmount in changeToGiveInDollars)
            {                
                changeCombination.Add(changeAmount);
                string key = GetChangeCombinationKey(changeCombination);
                runningTotal += changeAmount;
                if (runningTotal == moneyToBreak && !changeCombinations.ContainsKey(key))
                {
                    changeCombinations.Add(key, string.Empty);                               
                }
                else if(runningTotal < moneyToBreak)
                {
                    SetCombinationCount();
                }
                ResetRunningTotalAndChangeCombinationAtIndex(changeCombination.Count - 1);
            }
        }       

        private void ResetRunningTotalAndChangeCombinationAtIndex(int changeAmountIndex)
        {
            if(changeAmountIndex >= 0)
            {
                runningTotal -= changeCombination[changeAmountIndex];
                changeCombination.RemoveAt(changeAmountIndex);
            }            
        }

        private string GetChangeCombinationKey(List<int> changeCombination)
        {
            List<int> sortedChangeCombination = changeCombination.OrderBy(change => change).ToList();
            
            string combinationKey = string.Empty;

            int counter = 1;
            foreach(int change in sortedChangeCombination)
            {
                if(counter == sortedChangeCombination.Count)
                {
                    combinationKey += change.ToString();
                }
                else
                {
                    combinationKey += change.ToString() + ",";
                }
                
                counter++;
            }

            return combinationKey;
        }
    }
}
