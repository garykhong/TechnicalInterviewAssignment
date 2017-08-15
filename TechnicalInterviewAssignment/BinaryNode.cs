using System;
using System.Collections.Generic;

namespace TechnicalInterviewAssignment
{
    public class BinaryNode
    {
        public int Data { get; private set; }
        public BinaryNode LeftBinaryNode { get; private set; }
        public BinaryNode RightBinaryNode { get; private set; }
        public List<long> AllData { get; private set; }

        public BinaryNode()
        {
            AllData = new List<long>();
        }

        public BinaryNode(int data, BinaryNode left, BinaryNode right)
        {
            this.Data = data;
            this.LeftBinaryNode = left;
            this.RightBinaryNode = right;
            AllData = new List<long>();
        }

        public void SetAllData(List<long> allData)
        {            
            allData.Add(Data);
            if(LeftBinaryNode != null)
            {
                LeftBinaryNode.SetAllData(allData);
            }

            if(RightBinaryNode != null)
            {
                RightBinaryNode.SetAllData(allData);
            }
        }

        public void ResetAllData()
        {
            AllData = new List<long>();
        }

        public bool CanFindDataToSearchFor(long dataToSearchFor)
        {
            bool canFindDataToSearchFor = false;
            if(Data == dataToSearchFor)
            {
                return true;
            }
            else
            {
                if(dataToSearchFor < Data && LeftBinaryNode != null)
                {
                    canFindDataToSearchFor = 
                        LeftBinaryNode.CanFindDataToSearchFor(dataToSearchFor);
                }

                if(dataToSearchFor > Data && RightBinaryNode != null)
                {
                    canFindDataToSearchFor = 
                        RightBinaryNode.CanFindDataToSearchFor(dataToSearchFor);
                }
            }

            return canFindDataToSearchFor;
        }

        public bool AreChildrenNodesOnTheCorrectSideOfParent()
        {
            bool childrenNodesOnTheCorrectSideOfParent = true;
            if(LeftBinaryNode != null && childrenNodesOnTheCorrectSideOfParent)
            {
                if(LeftBinaryNode.Data >= Data)
                {
                    childrenNodesOnTheCorrectSideOfParent = false;
                }

                if(childrenNodesOnTheCorrectSideOfParent)
                {
                    childrenNodesOnTheCorrectSideOfParent =
                    LeftBinaryNode.AreChildrenNodesOnTheCorrectSideOfParent();
                }                               
            }

            if (RightBinaryNode != null && childrenNodesOnTheCorrectSideOfParent)
            {
                if (RightBinaryNode.Data <= Data)
                {
                    childrenNodesOnTheCorrectSideOfParent = false;
                }

                if(childrenNodesOnTheCorrectSideOfParent)
                {
                    childrenNodesOnTheCorrectSideOfParent =
                    RightBinaryNode.AreChildrenNodesOnTheCorrectSideOfParent();
                }                                
            }
            return childrenNodesOnTheCorrectSideOfParent;
        }

        public BinaryNode GetBinaryNodeFromNode(Node node, BinaryNode binaryNode)
        {
            binaryNode = new BinaryNode();
            binaryNode.Data = node.data;
            if(node.left == null)
            {
                binaryNode.LeftBinaryNode = null;
            }
            else
            {
                binaryNode.LeftBinaryNode = GetBinaryNodeFromNode(node.left, binaryNode.LeftBinaryNode);
            }

            if(node.right == null)
            {
                binaryNode.RightBinaryNode = null;
            }
            else
            {
                binaryNode.RightBinaryNode = GetBinaryNodeFromNode(node.right, binaryNode.RightBinaryNode);
            }

            return binaryNode;
        }
    }
}
