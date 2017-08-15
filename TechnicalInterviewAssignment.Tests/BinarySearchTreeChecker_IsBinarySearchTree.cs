using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class BinarySearchTreeChecker_IsBinarySearchTree
    {
        BinarySearchTreeChecker treeChecker;

        [TestMethod]
        public void Numbers1234567_GivesTrue()
        {
            BinaryNode oneNode = new BinaryNode(1, null, null);
            BinaryNode threeNode = new BinaryNode(3, null, null);
            BinaryNode twoNode = new BinaryNode(2, oneNode, threeNode);

            BinaryNode fiveNode = new BinaryNode(5, null, null);
            BinaryNode sevenNode = new BinaryNode(7, null, null);
            BinaryNode sixNode = new BinaryNode(6, fiveNode, sevenNode);

            BinaryNode fourNode = new BinaryNode(4, twoNode, sixNode);

            Assert.AreEqual(true, IsBinarySearchTree(fourNode));
        }

        [TestMethod]
        public void Numbers1243567_GivesFalse()
        {
            BinaryNode oneNode = new BinaryNode(1, null, null);
            BinaryNode fourNode = new BinaryNode(4, null, null);
            BinaryNode twoNode = new BinaryNode(2, oneNode, fourNode);

            BinaryNode fiveNode = new BinaryNode(5, null, null);
            BinaryNode sevenNode = new BinaryNode(7, null, null);
            BinaryNode sixNode = new BinaryNode(6, fiveNode, sevenNode);

            BinaryNode threeNode = new BinaryNode(3, twoNode, sixNode);

            Assert.AreEqual(false, IsBinarySearchTree(threeNode));
        }

        [TestMethod]
        public void Numbers1243567AsNode_GivesFalse()
        {
            Node oneNode = new Node { data = 1, left = null, right = null };
            Node fourNode = new Node { data = 4, left = null, right = null };
            Node twoNode = new Node { data = 2, left = oneNode, right = fourNode };

            Node fiveNode = new Node { data = 5, left = null, right = null };
            Node sevenNode = new Node { data = 7, left = null, right = null };
            Node sixNode = new Node { data = 6, left = fiveNode, right = sevenNode };

            Node threeNode = new Node { data = 3, left = twoNode, right = sixNode };

            Assert.AreEqual(false, IsBinarySearchTree(threeNode));
        }

        [TestMethod]
        public void Numbers1224567AsNode_GivesFalse()
        {
            Node oneNode = new Node { data = 1, left = null, right = null };
            Node firstTwoNode = new Node { data = 2, left = null, right = null };
            Node twoNode = new Node { data = 2, left = oneNode, right = firstTwoNode };

            Node fiveNode = new Node { data = 5, left = null, right = null };
            Node sevenNode = new Node { data = 7, left = null, right = null };
            Node sixNode = new Node { data = 6, left = fiveNode, right = sevenNode };

            Node fourNode = new Node { data = 4, left = twoNode, right = sixNode };

            Assert.AreEqual(false, IsBinarySearchTree(fourNode));
        }

        [TestMethod]
        public void Numbers16161819AsNode_GivesFalse()
        {
            Node nineteenNode = new Node { data = 19, left = null, right = null };
            Node firstSixteenNode = new Node { data = 16, left = null, right = null };
            Node eighteenNode = new Node { data = 18, left = firstSixteenNode, right = nineteenNode };
                      

            Node sixteenNode = new Node { data = 16, left = null, right = eighteenNode };

            Assert.AreEqual(false, IsBinarySearchTree(sixteenNode));
        }

        private bool IsBinarySearchTree(Node node)
        {
            treeChecker = new BinarySearchTreeChecker(node);
            return treeChecker.IsBinarySearchTree();
        }

        private bool IsBinarySearchTree(BinaryNode binaryNode)
        {
            treeChecker = new BinarySearchTreeChecker(binaryNode);
            return treeChecker.IsBinarySearchTree();
        }
    }
}
