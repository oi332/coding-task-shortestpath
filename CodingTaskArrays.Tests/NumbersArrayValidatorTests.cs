using CodingTaskArrays.BLL.Models;
using CodingTaskArrays.BLL.Validators;
using System;
using System.Collections.Generic;
using Xunit;

namespace CodingTaskArrays.Tests
{
    public class NumbersArrayValidatorTests
    {
        [Fact]
        public void IsValid_ArrayNumbersListIsEmpty_False()
        {
            var numbersArray = new NumbersArray { Numbers = new List<int> { } };

            var result = NumbersArrayValidator.IsValid(numbersArray);

            Assert.False(result);
        }

        [Fact]
        public void IsValid_ArrayNumberListIsNull_False()
        {
            var numbersArray = new NumbersArray();

            var result = NumbersArrayValidator.IsValid(numbersArray);

            Assert.False(result);
        }

        [Fact]
        public void IsValid_GoalIsReachable1_True()
        {
            var numbersArray = new NumbersArray { Numbers = new List<int> { 1, 2, 0, 3, 0, 2, 0} };

            var result = NumbersArrayValidator.IsValid(numbersArray);

            Assert.True(result);
        }

        [Fact]
        public void IsValid_GoalIsReachable2_True()
        {
            var numbersArray = new NumbersArray { Numbers = new List<int> { 1, 1, 1, 1, 1, 1, 1 } };

            var result = NumbersArrayValidator.IsValid(numbersArray);

            Assert.True(result);
        }

        [Fact]
        public void IsValid_GoalIsNotReachableNegativeNumber1_False()
        {
            var numbersArray = new NumbersArray { Numbers = new List<int> { 1, 2, 1, -1, 0, 2, 0 } };

            var result = NumbersArrayValidator.IsValid(numbersArray);

            Assert.False(result);
        }

        [Fact]
        public void IsValid_GoalIsNotReachableNegativeNumber2_False()
        {
            var numbersArray = new NumbersArray { Numbers = new List<int> { 1, 2, -2, -3, 0, 2, 0 } };

            var result = NumbersArrayValidator.IsValid(numbersArray);

            Assert.False(result);
        }

        [Fact]
        public void IsValid_GoalIsNotReachableOneZero_False()
        {
            var numbersArray = new NumbersArray { Numbers = new List<int> { 0 } };

            var result = NumbersArrayValidator.IsValid(numbersArray);

            Assert.False(result);
        }


    }
}
