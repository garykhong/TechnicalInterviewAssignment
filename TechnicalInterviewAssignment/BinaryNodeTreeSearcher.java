/* Hidden stub code will pass a root argument to the function below. Complete the function to solve the challenge. Hint: you may want to write one or more helper functions.  

The Node class is defined as follows:
    class Node {
        int data;
        Node left;
        Node right;
     }
*/
    boolean checkBST(Node root) {
        return new BinarySearchTreeChecker(root).IsBinarySearchTree();
    }

	public class BinarySearchTreeChecker
    {
        public BinaryNode HeadBinaryNode;

        public BinarySearchTreeChecker(Node head)
        {
            HeadBinaryNode = new BinaryNode().GetBinaryNodeFromNode(head, HeadBinaryNode);
        }

        public BinarySearchTreeChecker(BinaryNode head)
        {
            HeadBinaryNode = head;
        }
        public boolean IsBinarySearchTree()
        {            
            return HeadBinaryNode.AreChildrenNodesOnTheCorrectSideOfParent() && CanFindAllData() &&
                         !HasDuplicateData();
        }

        private boolean CanFindAllData()
        {
            HeadBinaryNode.SetAllData(HeadBinaryNode.AllData);
            for(int data : HeadBinaryNode.AllData)
            {
                if(!HeadBinaryNode.CanFindDataToSearchFor(data))
                {
                    return false;
                }
            }

            HeadBinaryNode.ResetAllData();

            return true;
        }
		
		private boolean HasDuplicateData()
        {
            HeadBinaryNode.SetAllData(HeadBinaryNode.AllData);
            for(int data : HeadBinaryNode.AllData)
            {
                if(HeadBinaryNode.AllData.indexOf(data) != HeadBinaryNode.AllData.lastIndexOf(data))
                {
                    return true;
                }
            }
            HeadBinaryNode.ResetAllData();
            return false;
        }
    }
	
public class BinaryNode
    {
        public int Data;
        public BinaryNode LeftBinaryNode;
        public BinaryNode RightBinaryNode;
        public ArrayList<Integer> AllData;

        public BinaryNode()
        {
            AllData = new ArrayList<Integer>();
        }

        public BinaryNode(int data, BinaryNode left, BinaryNode right)
        {
            this.Data = data;
            this.LeftBinaryNode = left;
            this.RightBinaryNode = right;
            AllData = new ArrayList<Integer>();
        }

        public void SetAllData(List<Integer> allData)
        {            
            allData.add(Data);
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
            AllData = new ArrayList<Integer>();
        }

        public boolean CanFindDataToSearchFor(int dataToSearchFor)
        {
            boolean canFindDataToSearchFor = false;
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

        public boolean AreChildrenNodesOnTheCorrectSideOfParent()
        {
            boolean childrenNodesOnTheCorrectSideOfParent = true;
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
