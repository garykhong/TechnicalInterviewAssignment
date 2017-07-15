namespace TechnicalInterviewAssignment
{
    public class ArrayRotator
    {
        private int NumberToShift { get; set; }
        private int NumberOfTimesToShift { get; set; }
        private int[] Numbers { get; set; }

        public ArrayRotator(int numberToShift, int numberOfTimesToShift, int[] numbers)
        {
            NumberToShift = numberToShift;
            NumberOfTimesToShift = numberOfTimesToShift;
            Numbers = numbers;
        }

        public int[] ShiftLeft()
        {
            int[] shiftedNumbers = new int[Numbers.Length];

            for (int i = 0; i < Numbers.Length; i++)
            {                
                shiftedNumbers[GetShiftedIndex(i)] = Numbers[i];
                shiftedNumbers[GetShiftedIndex(i)] = Numbers[i];
            }

            return shiftedNumbers;
        }

        private int GetShiftedIndex(int currentIndex)
        {
            int shiftedIndex = currentIndex - NumberOfTimesToShift;
            if (shiftedIndex < 0)
            {
                shiftedIndex = Numbers.Length + shiftedIndex;
            }

            return shiftedIndex;
        }
    }
}