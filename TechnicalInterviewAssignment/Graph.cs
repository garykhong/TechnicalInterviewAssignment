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

        public void AddEdge(int firstNodeValue, int secondNodeValue)
        {
            AddNodeToTree(firstNodeValue);
            AddNodeToTree(secondNodeValue);
            nodes[firstNodeValue].AddNodeToChildren(nodes[secondNodeValue]);
            nodes[secondNodeValue].AddNodeToChildren(nodes[firstNodeValue]);
        }

        private void AddNodeToTree(int nodeValue)
        {
            if (!nodes.ContainsKey(nodeValue))
            {
                nodes.Add(nodeValue, new NodeWithUnlimitedChildren() { Data = nodeValue });
            }
        }

        public int[] GetDistancesFromNode(int startingNodeValue)
        {
            int[] distancesFromNode = new int[totalNodes - 1];
            NodeWithUnlimitedChildren node = nodes[startingNodeValue];
            int distanceFromNodeIndex = 0;
            for (int nodeValue = 1; nodeValue <= totalNodes; nodeValue++)
            {
                if (nodeValue != startingNodeValue)
                {
                    distancesFromNode[distanceFromNodeIndex] = GetDistanceFromNode(nodeValue, node, new HashSet<int>(), 0);
                    distanceFromNodeIndex++;
                }
            }
            return distancesFromNode;
        }

        private int GetDistanceFromNode(int nodeValue, NodeWithUnlimitedChildren node, 
                                          HashSet<int> nodeValuesVisited, int distanceTravelled)
        {            
            if (node.Data == nodeValue)
            {
                return distanceTravelled;
            }


            if (node.Children.ContainsKey(nodeValue))
            {
                return distanceTravelled + 6;
            }

            int lowestDistanceTravelled = int.MaxValue;
            foreach (KeyValuePair<int, NodeWithUnlimitedChildren> childNode in node.Children)
            {
                if(!nodeValuesVisited.Contains(childNode.Value.Data))
                {                    
                    nodeValuesVisited.Add(childNode.Value.Data);
                    int distanceFromNode = GetDistanceFromNode(nodeValue, childNode.Value, 
                                                               nodeValuesVisited, distanceTravelled + 6);
                    if(distanceFromNode > -1)
                    {
                        distanceTravelled += distanceFromNode;
                    }
                    else
                    {
                        distanceTravelled = int.MaxValue;
                    }

                    if(distanceTravelled < lowestDistanceTravelled)
                    {
                        lowestDistanceTravelled = distanceTravelled;
                    }
                }                
            }

            if(lowestDistanceTravelled != int.MaxValue)
            {
                return lowestDistanceTravelled;
            }

            return -1;
        }
    }
}