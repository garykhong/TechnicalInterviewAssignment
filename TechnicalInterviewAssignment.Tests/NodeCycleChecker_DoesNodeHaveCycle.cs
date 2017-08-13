using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class NodeCycleChecker_DoesNodeHaveCycle
    {
        [TestMethod]
        public void SingleNode_GivesFalse()
        {
            Node node = new Node(1, null);
            Assert.AreEqual(false, 
                DoesNodeHaveCycle(node));
        }

        [TestMethod]
        public void TwoLinkedNodesBothVisitedOnce_GivesFalse()
        {
            Node node = new Node(1, new Node(2, null));
            Assert.AreEqual(false,
                DoesNodeHaveCycle(node));
        }

        [TestMethod]
        public void TwoLinkedNodesFirstNodeVisitedTwice_GivesTrue()
        {
            Node node = new Node(1, new Node(2, new Node(1, null)));
            Assert.AreEqual(true,
                DoesNodeHaveCycle(node));
        }

        private bool DoesNodeHaveCycle(Node headNode)
        {
            NodeCycleChecker checker =
                new NodeCycleChecker(headNode);
            return checker.DoesNodeHaveCycle();
        }
    }
}
