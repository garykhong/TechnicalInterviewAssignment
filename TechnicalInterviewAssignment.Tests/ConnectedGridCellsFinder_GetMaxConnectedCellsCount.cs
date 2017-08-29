using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class ConnectedGridCellsFinder_GetMaxConnectedCellsCount
    {
        [TestMethod]
        public void OneDimensionalSampleTestCase_GivesExpectedResults()
        {            
            Assert.AreEqual(2,
                GetMaxConnectedCellsCount(new int[][] { new int[] { 0, 1, 1 } }));
            Assert.AreEqual(3,
                GetMaxConnectedCellsCount(new int[][] { new int[] { 0, 1, 1, 0, 1, 1, 1 } }));
            Assert.AreEqual(3,
                GetMaxConnectedCellsCount(new int[][] { new int[] { 1, 1, 1, 0, 1} }));            
        }

        [TestMethod]
        public void TwoDimensionalSampleTestCase_GivesExpectedResults()
        {
            Assert.AreEqual(5,
                GetMaxConnectedCellsCount(new int[][] {
                                               new int[] { 1, 1, 0, 0 },
                                               new int[] { 0, 1, 1, 0 },
                                               new int[] { 0, 0, 1, 0 },
                                               new int[] { 1, 0, 0, 0 }
                                               }
                                          )
                            );
        }

        private int GetMaxConnectedCellsCount(int[][] grid)
        {
            ConnectedGridCellsFinder finder =
                new ConnectedGridCellsFinder(grid);
            return finder.GetMaxConnectedCellsCount();
        }
    }
}
