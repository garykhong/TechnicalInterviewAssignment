using System;
using System.Collections.Generic;

namespace TechnicalInterviewAssignment
{
    public class StaircaseStepCombinationCalculator
    {
        private int steps;
        private int totalCombinations;

        public StaircaseStepCombinationCalculator(int steps)
        {
            this.steps = steps;
        }

        public int GetCombinationCount()
        {
            CalculateStepCombinationCount(0);
            return totalCombinations;
        }

        private void CalculateStepCombinationCount(int stepsTaken)
        {
            for(int numberOfStepsToTake = 1; numberOfStepsToTake <= 3; numberOfStepsToTake++)
            {
                if(stepsTaken == steps)
                {
                    totalCombinations += 1;
                    return;
                }
                else if(stepsTaken > steps)
                {
                    return;
                }
                else if(stepsTaken < steps)
                {
                    CalculateStepCombinationCount(stepsTaken + numberOfStepsToTake);
                }
            }
        }
    }
}
