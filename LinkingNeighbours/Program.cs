using System;

namespace LinkingNeighbours
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var tree1 = new Node(
                "A",
                new Node("B",
                    new Node("D"),
                    new Node("E")),
                new Node("C",
                    null,
                    new Node("F")));
            ExecuteTest(1, tree1);
            
            var tree2 = new Node("A", new Node("B", new Node("C")));
            ExecuteTest(2, tree2);
            
            var tree3 = new Node(
                "A",
                new Node("B",
                    new Node("D",
                        null,
                        new Node("G"))),
                new Node("C",
                    new Node("E"),
                    new Node("F",
                        new Node("H",
                            null,
                            new Node("I")))));
            
            ExecuteTest(3, tree3);
        }

        private static void ExecuteTest(int testCount, Node tree)
        {
            Console.WriteLine();
            Console.WriteLine($"Tree {testCount}:");
            var withList = new AlgorithmWithList(tree);
            withList.Execute();
            
            Console.WriteLine();

            var withoutList = new AlgorithmWithoutList(tree);
            withoutList.Execute();
            
            Console.WriteLine();
        }
    }
}