using CodingTaskArrays.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTaskArrays.BLL.Services
{
    public class NumbersArrayService : INumbersArrayService
    {
        public NumbersArrayDto Validate(NumbersArrayDto numbersArrayDto)
        {
            var graph = GraphBuilder.Build(numbersArrayDto);
            var shortestPath = ShortestPathFinder.FindShortestPathFromStartToEndBFS(graph);

            numbersArrayDto.ShortestPath = shortestPath;

            return numbersArrayDto;
        }
    }
}
