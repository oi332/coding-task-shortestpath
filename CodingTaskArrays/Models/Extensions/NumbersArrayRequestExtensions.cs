using CodingTaskArrays.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTaskArrays.Models.Extensions
{
    public static class NumbersArrayRequestExtensions
    {
        public static NumbersArrayDto ToDto(this NumbersArrayRequest numbersArrayRequest)
        {
            return new NumbersArrayDto
            {
                Numbers = numbersArrayRequest.Numbers,
            };
        }
    }
}
