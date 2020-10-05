using Xunit;
using MathAPI.MultipleOf.Interfaces;
using System.Linq;
using MathAPI.MultipleOf.Result;
using System.Collections.Generic;

namespace MathAPI.Tests
{
    public class MultipleOfElevenTests
    {
        private readonly IMultipleOfEleven multipleOfEleven;

        public MultipleOfElevenTests(IMultipleOfEleven multipleOfEleven) 
        {
            this.multipleOfEleven = multipleOfEleven;
        }

        [Fact]
        public void IsMultiple_ReturnedValue_Boolean()
        {
            string input = "44";
            var result = multipleOfEleven.IsMultiple(input);
            Assert.IsType<bool>(result);
        }

        [Fact]
        public void IsMultiple_InputIs1_ReturnFalse()
        {
            string input = "1";
            bool isMultiple = multipleOfEleven.IsMultiple(input);
            Assert.False(isMultiple, $"{input} should not be multiple of 11");
        }

        [Fact]
        public void IsMultiple_InputIs11_ReturnTrue()
        {
            string input = "11";
            bool isMultiple = multipleOfEleven.IsMultiple(input);
            Assert.True(isMultiple, $"{input} should be multiple of 11");
        }

        [Fact]
        public void IsMultiple_InputIs874Negative_ReturnFalse()
        {
            string input = "-874";
            bool isMultiple = multipleOfEleven.IsMultiple(input);
            Assert.False(isMultiple, $"{input} should not be multiple of 11");
        }

        [Fact]
        public void IsMultiple_InputIs154Negative_ReturnTrue()
        {
            string input = "-154";
            bool isMultiple = multipleOfEleven.IsMultiple(input);
            Assert.True(isMultiple, $"{input} should be multiple of 11");
        }

        [Fact]
        public void IsMultiple_InputIsLongNumber_ReturnTrue()
        {
            string input = "4611686018427387901307445734561825860123058430092136939501844674407370955160";
            bool isMultiple = multipleOfEleven.IsMultiple(input);
            Assert.True(isMultiple, $"{input} should be multiple of 11");
        }

        [Fact]
        public void IsMultiple_InputIsLongNumber_ReturnFalse()
        {
            string input = "4611686018427387903307445734561825860223058430092136939511844674407370955161";
            bool isMultiple = multipleOfEleven.IsMultiple(input);
            Assert.False(isMultiple, $"{input} should not be multiple of 11");
        }

        [Fact]
        public void IsMultiple_ReturnedObject_ArrayIsMultipleResult()
        {
            string[] input = new string[] { "3", "22", "-33" };
            var result = multipleOfEleven.IsMultiple(input).ToList();
            Assert.IsType<List<IsMultipleResult>>(result);
        }

        [Fact]
        public void IsMultiple_InputIsArray_ReturnTrue()
        {
            string[] input = new string[] { "4611686018427387901307445734561825860123058430092136939501844674407370955160", "11", "-154" };
            var result = multipleOfEleven.IsMultiple(input);
            Assert.True(result.Where(r => r.IsMultiple).Count() == result.Count(), "All numbers on array are multiple of 11");
        }

        [Fact]
        public void IsMultiple_InputIsArray_ReturnFalse()
        {
            string[] input = new string[] { "4611686018427387903307445734561825860223058430092136939511844674407370955161", "1", "-874" };
            var result = multipleOfEleven.IsMultiple(input);
            Assert.True(result.Where(r => !r.IsMultiple).Count() == result.Count(), "All numbers on array are not multiple of 11");
        }

        [Theory]
        [InlineData("ABC")]
        [InlineData("12.90")]
        [InlineData("R$22")]
        [InlineData("")]
        [InlineData(null)]
        public void IsMultiple_InputIsInvalid_ReturnFalse(string value)
        {
            bool isMultiple = multipleOfEleven.IsMultiple(value);
            Assert.False(isMultiple, $"{value} should not be multiple of 11");
        }
    }
}
