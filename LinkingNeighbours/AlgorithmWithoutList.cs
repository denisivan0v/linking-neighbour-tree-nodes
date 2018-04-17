using System;
using System.Collections.Generic;

namespace LinkingNeighbours
{
    public class AlgorithmWithoutList
    {
        private readonly Node _root;

        public AlgorithmWithoutList(Node root)
        {
            _root = root;
        }

        public void Execute()
        {
            var queue = new Queue<Node>();

            queue.Enqueue(_root);
            
            // Adding a level separator
            queue.Enqueue(null);
            
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                Console.Write($"{node?.Value ?? "NULL"}");

                if (node == null)
                {
                    // Re-enqueueing the level separator if we're not done yet
                    if (queue.Count > 0)
                    {
                        queue.Enqueue(null);
                    }
                    
                    Console.Write(" ");
                }
                else
                {
                    // We already have all level items in the queue, so we can just link neighbours here
                    var next = queue.Peek();
                    if (next != null)
                    {
                        node.Next = next;
                    }

                    if (node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                    }

                    if (node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                    }
                    
                    Console.Write("->");
                }
            }
        }
    }
}