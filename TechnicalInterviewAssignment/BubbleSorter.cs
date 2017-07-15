namespace TechnicalInterviewAssignment
{
    public class BubbleSorter
    {
        private int numberOfSwaps;
        public int NumberOfSwaps { get { return numberOfSwaps; } }
        private int[] Numbers { get; set; }

        public BubbleSorter(int[] numbers)
        {
            Numbers = numbers;
        }

        public int[] SortNumbers()
        {
            bool continueSorting = true;
            while(continueSorting)
            {
                continueSorting = false;
                for(int i = 0; i < Numbers.Length - 1; i++)
                {
                    if(Numbers[i] > Numbers[i + 1])
                    {
                        SwapNumberWithNextNumberInNumbers(i);
                        numberOfSwaps++;
                        continueSorting = true;
                    }
                }
            }

            return Numbers;
        }

        private void SwapNumberWithNextNumberInNumbers(int index)
        {
            int number = Numbers[index];
            int nextNumber = Numbers[index + 1];
            Numbers[index] = nextNumber;
            Numbers[index + 1] = number;
        }

        
    }
}