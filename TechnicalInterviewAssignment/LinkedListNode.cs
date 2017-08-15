namespace TechnicalInterviewAssignment
{
    public class LinkedListNode
    {
        public int Data { get; }
        public LinkedListNode NextNode { get; }

        public LinkedListNode(int data, LinkedListNode nextNode)
        {
            this.Data = data;
            this.NextNode = nextNode;
        }
    }
}