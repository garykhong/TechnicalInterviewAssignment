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
            LinkedListNode node = new LinkedListNode(1, null);
            Assert.AreEqual(false, 
                DoesNodeHaveCycle(node));
        }

        [TestMethod]
        public void TwoLinkedNodesBothVisitedOnce_GivesFalse()
        {
            LinkedListNode node = new LinkedListNode(1, new LinkedListNode(2, null));
            Assert.AreEqual(false,
                DoesNodeHaveCycle(node));
        }

        [TestMethod]
        public void TwoLinkedNodesFirstNodeVisitedTwice_GivesTrue()
        {
            LinkedListNode node = new LinkedListNode(1, new LinkedListNode(2, new LinkedListNode(1, null)));
            Assert.AreEqual(true,
                DoesNodeHaveCycle(node));
        }

        private bool DoesNodeHaveCycle(LinkedListNode headNode)
        {
            NodeCycleChecker checker =
                new NodeCycleChecker(headNode);
            return checker.DoesNodeHaveCycle();
        }
    }
}
