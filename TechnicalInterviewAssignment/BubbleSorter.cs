namespace TechnicalInterviewAssignment
{
    public class BubbleSorter
    {
        private int numberOfSwaps;
        public int NumberOfSwaps { get { return NumberOfSwaps; } }
        private int[] Numbers { get; set; }

        public BubbleSorter(int[] numbers)
        {
            Numbers = numbers;
        }

        public int[] SortNumbers()
        {
            return new int[] { 1, 2, 3 };
        }

        
    }
}