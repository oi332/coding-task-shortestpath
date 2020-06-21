using System.Collections.Generic;
using System.Collections.Specialized;
using CodingTaskArrays.BLL.Models;
using CodingTaskArrays.BLL.Validators.Models;

namespace CodingTaskArrays.BLL
{
    public static class ShortestPathFinder
    {
        public static List<int> FindShortestPathFromStartToEndBFS(Graph graph)
        {
            if (!graph.Relations.ContainsKey(0))
            {
                return null;
            }

            var queue = new Queue<int>();
            var visited = new HashSet<int>();
            var parentNodes = new Dictionary<int, int>();
            var destination = graph.Relations.Count - 1;

            queue.Enqueue(0);
            visited.Add(0);

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();

                visited.Add(node);

                if (graph.Relations.TryGetValue(node, out HashSet<int> neighbors))
                {
                    foreach (var neighbor in neighbors)
                    {
                        parentNodes.TryAdd(neighbor, node);

                        if (neighbor == destination)
                        {
                            return TraverseParentNodesToFindShortestPath(parentNodes, destination);
                        }

                        if (!visited.Contains(neighbor))
                        {
                            queue.Enqueue(neighbor);
                        }
                    }
                }
            }

            return null;
        }

        private static List<int> TraverseParentNodesToFindShortestPath(Dictionary<int, int> parentNodes, int destination)
        {
            var shortestPath = new List<int>();

            var node = destination;
            var done = false;

            while (!done)
            {
                shortestPath.Add(node);

                done = !parentNodes.TryGetValue(node, out node);
            }

            shortestPath.Reverse();

            return shortestPath;
        }


    }
}
