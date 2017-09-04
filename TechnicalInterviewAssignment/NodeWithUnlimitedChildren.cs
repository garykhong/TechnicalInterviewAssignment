using System.Collections.Generic;
namespace TechnicalInterviewAssignment
{
    public class NodeWithUnlimitedChildren
    {
        public int Data;
        public List<NodeWithUnlimitedChildren> Children = new List<NodeWithUnlimitedChildren>();
    }
}