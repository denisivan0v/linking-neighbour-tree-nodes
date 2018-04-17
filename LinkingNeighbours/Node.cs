namespace LinkingNeighbours
{
    public class Node 
    {
        public Node(string value, Node left = null, Node right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }

        public string Value { get; }
        public Node Left { get; }
        public Node Right { get; }
        
        public Node Next { get; set; }
    }
}