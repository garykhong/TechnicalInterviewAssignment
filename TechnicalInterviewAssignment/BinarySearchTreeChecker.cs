using System;
using System.Collections.Generic;

namespace TechnicalInterviewAssignment
{
    public class BinarySearchTreeChecker
    {
        public BinaryNode HeadBinaryNode { get; private set; }

        public BinarySearchTreeChecker(Node head)
        {
            HeadBinaryNode = new BinaryNode().GetBinaryNodeFromNode(head, HeadBinaryNode);
        }

        public BinarySearchTreeChecker(BinaryNode head)
        {
            HeadBinaryNode = head;
        }
        public bool IsBinarySearchTree()
        {            
            return HeadBinaryNode.AreChildrenNodesOnTheCorrectSideOfParent() && CanFindAllData() &&
                         !HasDuplicateData();
        }

        private bool CanFindAllData()
        {
            HeadBinaryNode.SetAllData(HeadBinaryNode.AllData);
            foreach(long data in HeadBinaryNode.AllData)
            {
                if(!HeadBinaryNode.CanFindDataToSearchFor(data))
                {
                    return false;
                }
            }

            HeadBinaryNode.ResetAllData();

            return true;
        }

        private bool HasDuplicateData()
        {
            HeadBinaryNode.SetAllData(HeadBinaryNode.AllData);
            foreach(long data in HeadBinaryNode.AllData)
            {
                if(HeadBinaryNode.AllData.IndexOf(data) != HeadBinaryNode.AllData.LastIndexOf(data))
                {
                    return true;
                }
            }
            HeadBinaryNode.ResetAllData();
            return false;
        }
    }
}
