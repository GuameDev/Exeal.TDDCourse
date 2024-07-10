namespace Exeal.StringCalculator.TDD.Tests
{
    public class StringCalculatorAddSpecs
    {
        [Theory]
        [InlineData("3,5", 8)]
        [InlineData("4,5", 9)]
        [InlineData("5,5", 10)]
        [InlineData("5,5,5", 15)]
        [InlineData("1,2,3", 6)]
        public void Add_GivenAnyNumbersReturnSum(string numbers, int expectedResult)
        {
            var result = StringCalculator.Add(numbers);
            Assert.Equal(expectedResult, result);
        }


        [Theory]
        [InlineData("3,5", 8)]
        [InlineData("4\n5", 9)]
        [InlineData("5,5", 10)]
        [InlineData("5\n5,5", 15)]
        [InlineData("1\n2\n3", 6)]
        public void Add_GivenNewLineAsSeparatorReturnSum(string numbers, int expectedResult)
        {
            var result = StringCalculator.Add(numbers);
            Assert.Equal(expectedResult, result);
        }

    }
}