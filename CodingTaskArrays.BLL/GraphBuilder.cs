using CodingTaskArrays.BLL.Models;
using CodingTaskArrays.BLL.Validators.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTaskArrays.BLL
{
    public static class GraphBuilder
    {
        public static Graph Build(NumbersArray numbersArray)
        {
            var arr = numbersArray.Numbers;
            var relations = new Dictionary<int, HashSet<int>>();

            for (int i = 0; i < arr.Count; i++)
            {
                var neighbors = new HashSet<int>();

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
