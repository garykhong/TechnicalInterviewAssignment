using System;
using System.Collections.Generic;

namespace TechnicalInterviewAssignment
{
    public class ConnectedGridCellsFinder
    {
        private int[][] grid;
        private HashSet<string> travelledCells = new HashSet<string>();

        public ConnectedGridCellsFinder(int[][] grid)
        {
            this.grid = grid;
        }

        public int GetMaxConnectedCellsCount()
        {
            int rowIndex = 0;
            int columnIndex = 0;
            int maxConnectedCellsCount = 0;

            for(columnIndex = 0; columnIndex < grid.Length; columnIndex++)
            {
                for(rowIndex = 0; rowIndex < grid[columnIndex].Length; rowIndex++)
                {
                    int singleCellConnectedCellsCount = GetMaxConnectedCellsCount(columnIndex, rowIndex);
                    travelledCells.Clear();
                    if (singleCellConnectedCellsCount > maxConnectedCellsCount)
                    {
                        maxConnectedCellsCount = singleCellConnectedCellsCount;
                    }
                }
            }
            return maxConnectedCellsCount;
        }

        private int GetMaxConnectedCellsCount(int columnIndex, int rowIndex)
        {
            string travelledCellsKey = columnIndex + "-" + rowIndex;
            int cellValue = 0;
            if(columnIndex >= 0 && rowIndex >= 0 && 
                columnIndex < grid.Length && rowIndex < grid[0].Length)
            {
                cellValue = grid[columnIndex][rowIndex];
            }
                
            if (cellValue == 0 || travelledCells.Contains(travelledCellsKey))
            {
                return 0;
            }

            int singleCellConnectedCellsCount = 0;
            if (cellValue == 1)
            {
                singleCellConnectedCellsCount++;
                travelledCells.Add(travelledCellsKey);
                singleCellConnectedCellsCount += GetMaxConnectedCellsCount(columnIndex - 1, rowIndex);
                singleCellConnectedCellsCount += GetMaxConnectedCellsCount(columnIndex - 1, rowIndex - 1);
                singleCellConnectedCellsCount += GetMaxConnectedCellsCount(columnIndex - 1, rowIndex + 1);
                singleCellConnectedCellsCount += GetMaxConnectedCellsCount(columnIndex, rowIndex - 1);
                singleCellConnectedCellsCount += GetMaxConnectedCellsCount(columnIndex, rowIndex + 1);
                singleCellConnectedCellsCount += GetMaxConnectedCellsCount(columnIndex + 1, rowIndex);
                singleCellConnectedCellsCount += GetMaxConnectedCellsCount(columnIndex + 1, rowIndex - 1);
                singleCellConnectedCellsCount += GetMaxConnectedCellsCount(columnIndex + 1, rowIndex + 1);
            }

            return singleCellConnectedCellsCount;
        }
    }
}
