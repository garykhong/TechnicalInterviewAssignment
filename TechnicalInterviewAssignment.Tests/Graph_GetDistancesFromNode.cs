using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class Graph_GetDistancesFromNode
    {
        [TestMethod]
        public void SampleTestCase_GivesExpectedResults()
        {
            Graph graph = new Graph(4);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            CollectionAssert.AreEqual(new int[] { 6, 6, -1},
                GetDistancesFromNode(graph, 1));
        }

        [TestMethod]
        public void SampleTestCase1_GivesExpectedResults()
        {
            Graph graph = new Graph(3);
            graph.AddEdge(2, 3);            
            CollectionAssert.AreEqual(new int[] { -1, 6 },
                GetDistancesFromNode(graph, 2));
        }

        private int[] GetDistancesFromNode(Graph graph, int nodeValue)
        {
            return graph.GetDistancesFromNode(nodeValue);
        }
    }
}
