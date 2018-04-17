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

            var tree4 = new Node(
                "1",
                new Node("2",
                    new Node("4",
                        new Node("8",
                            new Node("16"),
                            new Node("17")),
                        new Node("9",
                            new Node("18"),
                            new Node("19"))),
                    new Node("5",
                        new Node("10",
                            new Node("20"),
                            new Node("21")),
                        new Node("11",
                            new Node("22"),
                            new Node("23")))),
                new Node("3",
                    new Node("6",
                        new Node("12",
                            new Node("24"),
                            new Node("25")),
                        new Node("13",
                            new Node("26"),
                            new Node("27"))),
                    new Node("7",
                        new Node("14",
                            new Node("28"),
                            new Node("29")),
                        new Node("15",
                            new Node("20"),
                            new Node("31")))));
            
            ExecuteTest(4, tree4);
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