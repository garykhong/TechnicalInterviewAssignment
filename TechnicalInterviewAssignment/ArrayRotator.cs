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
            /*System.Collections.Generic.List<int> numbers = new System.Collections.Generic.List<int>();
            for(int i=0; i < Numbers.Length; i++)
            {
                numbers.Add(Numbers[i]);
            }

            int indexOfNumberToShift = numbers.IndexOf(NumberToShift);
            int leftShiftedIndexOfNumberToShift = indexOfNumberToShift - NumberOfTimesToShift;
            numbers.Remove(NumberToShift);
            numbers.Insert(leftShiftedIndexOfNumberToShift, NumberToShift);
            return numbers.ToArray();*/

            int[] shiftedNumbers = new int[Numbers.Length];
            for (int i = 0; i < Numbers.Length; i++)
            {
                int shiftedIndex = i - NumberOfTimesToShift;
                if (shiftedIndex < 0)
                {
                    shiftedIndex = Numbers.Length + shiftedIndex;
                }
                shiftedNumbers[shiftedIndex] = Numbers[i];
            }
            return shiftedNumbers;
        }
    }
}