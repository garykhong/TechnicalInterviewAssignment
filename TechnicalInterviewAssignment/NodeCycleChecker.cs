using System;
using System.Collections.Generic;
using System.Linq;

namespace TechnicalInterviewAssignment
{
    public class NodeCycleChecker
    {
        private Node headNode;

        public NodeCycleChecker(Node headNode)
        {
            this.headNode = headNode;
        }

        public bool DoesNodeHaveCycle()
        {
            List<int> nodesVisited = new List<int> { headNode.Data };

            Node nextNode = headNode.NextNode;
            while (nextNode != null)
            {
                nodesVisited.Add(nextNode.Data);
                if(nodesVisited.Count(data => data == nextNode.Data) > 1)
                {
                    return true;
                }
                nextNode = nextNode.NextNode;
            }

            return false;
        }
    }
}