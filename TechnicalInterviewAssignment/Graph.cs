using System;
using System.Collections.Generic;

namespace TechnicalInterviewAssignment
{
    public class Graph
    {
        private int totalNodes;
        private Dictionary<int, NodeWithUnlimitedChildren> nodes = new Dictionary<int, NodeWithUnlimitedChildren>();

        public Graph(int totalNodes)
        {
            this.totalNodes = totalNodes;
        }

        public void AddEdge(int startingNodeValue, int endingNodeValue)
        {
            if (nodes.ContainsKey(startingNodeValue))
            {
                nodes[startingNodeValue].Children.Add(
                    new NodeWithUnlimitedChildren
                    {
                        Data = endingNodeValue
                    }
                    );

            }
            else
            {
                nodes.Add(startingNodeValue, new NodeWithUnlimitedChildren
                {
                    Data = startingNodeValue,
                    Children = {
                        new NodeWithUnlimitedChildren
                        {
                            Data = endingNodeValue
                        }
                    }
                });
            }
        }

        public int[] GetDistancesFromNode(int startingNodeValue)
        {
            int[] distancesFromNode = new int[totalNodes - 1];
            NodeWithUnlimitedChildren node = nodes[startingNodeValue];
            int distanceFromNodeIndex = 0;
            for(int nodeValue = 1; nodeValue <= totalNodes; nodeValue++)
            {
                if(nodeValue != startingNodeValue)
                {
                    distancesFromNode[distanceFromNodeIndex] = GetDistanceFromNode(nodeValue, node);
                    distanceFromNodeIndex++;
                }                
            }
            return distancesFromNode;
        }

        private int GetDistanceFromNode(int nodeValue, NodeWithUnlimitedChildren node)
        {
            int distanceTravelled = 0;
            if(node.Data == nodeValue)
            {
                return 0;
            }

            foreach (NodeWithUnlimitedChildren childNode in node.Children)
            {
                if (childNode.Data == nodeValue)
                {
                    return 6;
                }
            }

            foreach(NodeWithUnlimitedChildren childNode in node.Children)
            {
                distanceTravelled += GetDistanceFromNode(nodeValue, childNode);
            }

            return -1;
        }
    }
}