namespace TechnicalInterviewAssignment
{
    public class Node
    {
        public int Data { get; }
        public Node NextNode { get; }

        public Node(int data, Node nextNode)
        {
            this.Data = data;
            this.NextNode = nextNode;
        }
    }
}