using System;
using System.Collections.Generic;

namespace LinkingNeighbours
{
    public class AlgorithmWithList
    {
        private readonly Node _root;

        public AlgorithmWithList(Node root)
        {
            _root = root;
        }

        public void Execute()
        {
            var result = new List<Node>();
            var queue = new Queue<Node>();
            
            queue.Enqueue(_root);
            result.Add(_root);
            
            // Adding a level separator
            queue.Enqueue(null);
            result.Add(null);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (node == null)
                {
                    if (queue.Count > 0)
                    {
                        // Re-enqueueing the level separator if we're not done yet
                        queue.Enqueue(null);
                        result.Add(null);
                    }
                }
                else
                {
                    if (node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                        result.Add(node.Left);
                    }

                    if (node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                        result.Add(node.Right);
                    }
                }
            }

            // Linking node to its non-null neighbour
            for (var i = 0; i < result.Count; i++)
            {
                var node = result[i];
                Console.Write($"{node?.Value ?? "NULL"}");

                if (node != null)
                {
                    node.Next = result[i + 1];
                    Console.Write("->");
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }
}