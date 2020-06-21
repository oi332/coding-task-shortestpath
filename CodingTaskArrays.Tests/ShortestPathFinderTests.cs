using CodingTaskArrays.BLL;
using CodingTaskArrays.BLL.Models;
using CodingTaskArrays.BLL.Validators;
using System;
using System.Collections.Generic;
using Xunit;

namespace CodingTaskArrays.Tests
{
    public class ShortestPathFinderTests
    {
        [Fact]
        public void IsValid_ArrayNumbersListIsEmpty_False()
        {
            var numbersArray = new NumbersArray { Numbers = new List<int> { 1, 2, 0, 3, 0, 2, 0 } };

            var result = ShortestPathFinder.FindShortestPathFromStartToEndBFS(GraphBuilder.Build(numbersArray));
            var expected = new List<int>() { 0, 1, 3, 6 };

            Assert.Equal(expected, result);
        }
    }
}
