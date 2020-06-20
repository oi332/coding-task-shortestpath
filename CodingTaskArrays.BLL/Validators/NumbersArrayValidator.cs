using System.Collections.Generic;
using System.Collections.Specialized;
using CodingTaskArrays.BLL.Models;
using CodingTaskArrays.BLL.Validators.Models;

namespace CodingTaskArrays.BLL.Validators
{
    public static class NumbersArrayValidator
    {
        public static bool IsValid(NumbersArray numbersArray)
        {
            if (numbersArray.Numbers is null)
                return false;

            var graph = MakeGraph(numbersArray);

            return IsGoalReachable(graph, numbersArray.Numbers.Count - 1);
        }

        private static bool IsGoalReachable(Graph graph, int destination)
        {
            var queue = new Queue<int>();
            var visited = new HashSet<int>();

            if (!graph.Relations.ContainsKey(0))
            {
                return false;
            }

            queue.Enqueue(0);
            visited.Add(0);

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();

                visited.Add(node);

                if (graph.Relations.TryGetValue(node, out List<int> neighbors))
                {
                    foreach (var neighbor in neighbors)
                    {
                        if (neighbor == destination)
                        {
                            return true;
                        }

                        if (!visited.Contains(neighbor))
                        {
                            queue.Enqueue(neighbor);
                        }
                    }
                }
            }


            return false;
        }

        private static Graph MakeGraph(NumbersArray numbersArray)
        {
            var arr = numbersArray.Numbers;
            var relations = new Dictionary<int, List<int>>();

            for (int i = 0; i < arr.Count; i++)
            {
                var neighbors = new List<int>();

                if (arr[i] < 0)
                {
                    for (int j = 1; j <= -arr[i]; j++)
                    {
                        neighbors.Add(i - j);
                    }
                }
                else
                {
                    for (int j = 1; j <= arr[i]; j++)
                    {
                        neighbors.Add(i + j);
                    }
                }

                relations.Add(i, neighbors);
            }

            return new Graph { Relations = relations };
        }
    }
}
