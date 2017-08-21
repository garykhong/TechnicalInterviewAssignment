using System;
using System.Collections.Generic;

namespace TechnicalInterviewAssignment
{
    public class StaircaseStepCombinationCalculator
    {
        private int steps;
        private Dictionary<int, int> stepCombinations;

        public StaircaseStepCombinationCalculator(int steps)
        {
            this.steps = steps;
            stepCombinations = new Dictionary<int, int>();
        }

        public int GetCombinationCount()
        {
            CalculateStepCombinationCount();
            return stepCombinations[steps];
        }

        private void SetStepCombinationsFirstThreeSteps()
        {
            stepCombinations.Add(1, 1);
            stepCombinations.Add(2, 2);
            stepCombinations.Add(3, 4);
        }

        private void CalculateStepCombinationCount()
        {
            SetStepCombinationsFirstThreeSteps();

            for (int index = 4; index <= steps; index++)
            {
                int thisStepCombinationsTotal = 
                    stepCombinations[index - 3] + stepCombinations[index - 2] + stepCombinations[index - 1];
                stepCombinations.Add(index, thisStepCombinationsTotal);
            }
        }
    }
}
