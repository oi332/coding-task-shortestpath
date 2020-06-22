using CodingTaskArrays.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTaskArrays.Models.Extensions
{
    public static class NumbersArrayResponseExtensions
    {
        public static NumbersArrayResponse ToResponse(this NumbersArrayDto numbersArrayDto)
        {
            return new NumbersArrayResponse
            {
                Id = numbersArrayDto.Id,
                Numbers = numbersArrayDto.Numbers,
                ShortestPath = numbersArrayDto.ShortestPath,
            };
        }

        public static IEnumerable<NumbersArrayResponse> ToResponse(this IEnumerable<NumbersArrayDto> numbersArrayDto)
        {
            return numbersArrayDto.Select(nad => new NumbersArrayResponse
            {
                Id = nad.Id,
                Numbers = nad.Numbers,
                ShortestPath = nad.ShortestPath,
            });
        }
    }
}
