using CodingTaskArrays.BLL;
using CodingTaskArrays.BLL.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace CodingTaskArrays.Tests
{
    public class ShortestPathFinderTests
    {
        [Fact]
        public void FindShortestPathFromStartToEndBFS_GoalIsReachable()
        {
            var numbersArray = new NumbersArrayDto { Numbers = new List<int> { 1, 2, 0, 3, 0, 2, 0 } };

            var result = ShortestPathFinder.FindShortestPathFromStartToEndBFS(GraphBuilder.Build(numbersArray));
            var expected = new List<int>() { 0, 1, 3, 6 };

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindShortestPathFromStartToEndBFS_GoalIsNotReachableEmptyNumbersArray()
        {
            var numbersArray = new NumbersArrayDto { Numbers = new List<int> { } };

            var result = ShortestPathFinder.FindShortestPathFromStartToEndBFS(GraphBuilder.Build(numbersArray));

            Assert.Null(result);
        }

        [Fact]
        public void FindShortestPathFromStartToEndBFS_GoalIsReachableAllOnes()
        {
            var numbersArray = new NumbersArrayDto { Numbers = new List<int> { 1, 1, 1, 1 } };

            var result = ShortestPathFinder.FindShortestPathFromStartToEndBFS(GraphBuilder.Build(numbersArray));
            var expected = new List<int>() { 0, 1, 2, 3 };

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindShortestPathFromStartToEndBFS_GoalIsNotReachableAllZeros()
        {
            var numbersArray = new NumbersArrayDto { Numbers = new List<int> { 0, 0, 0, 0 } };

            var result = ShortestPathFinder.FindShortestPathFromStartToEndBFS(GraphBuilder.Build(numbersArray));

            Assert.Null(result);
        }

        [Fact]
        public void FindShortestPathFromStartToEndBFS_GoalIsNotReachable2()
        {
            var numbersArray = new NumbersArrayDto { Numbers = new List<int> { 1, 2, 0, 1, 0, 2, 0 } };

            var result = ShortestPathFinder.FindShortestPathFromStartToEndBFS(GraphBuilder.Build(numbersArray));

            Assert.Null(result);
        }

        [Fact]
        public void FindShortestPathFromStartToEndBFS_GoalIsNotReachableNegativeNumber1()
        {
            var numbersArray = new NumbersArrayDto { Numbers = new List<int> { 1, 2, 1, -1, 0, 2, 0 } };

            var result = ShortestPathFinder.FindShortestPathFromStartToEndBFS(GraphBuilder.Build(numbersArray));

            Assert.Null(result);
        }

        [Fact]
        public void FindShortestPathFromStartToEndBFS_GoalIsNotReachableNegativeNumber2()
        {
            var numbersArray = new NumbersArrayDto { Numbers = new List<int> { 1, 2, 0, -1, 0, 2, 0 } };

            var result = ShortestPathFinder.FindShortestPathFromStartToEndBFS(GraphBuilder.Build(numbersArray));

            Assert.Null(result);
        }
    }
}
