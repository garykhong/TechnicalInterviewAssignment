using System;
using System.Collections.Generic;
namespace TechnicalInterviewAssignment
{
    public class NodeWithUnlimitedChildren
    {
        public int Data;
        public Dictionary<int, NodeWithUnlimitedChildren> Children = new Dictionary<int, NodeWithUnlimitedChildren>();

        public void AddNodeToChildren(NodeWithUnlimitedChildren childNodeToAdd)
        {
            if (!Children.ContainsKey(childNodeToAdd.Data))
            {
                Children.Add(childNodeToAdd.Data, childNodeToAdd);
            }
        }
    }
}