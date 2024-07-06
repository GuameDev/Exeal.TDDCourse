namespace Exeal.FizzBuzz.TDD.Tests
{
    public class FizzBuzzSpecs
    {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(27)]
        public void ReturnFizzForMultiplesOf3(int number)
        {
            var result = FizzBuzzer.FizzBuzz(number);
            Assert.Equal("Fizz", result);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(25)]
        public void ReturnBuzzForMultiplesOf5(int number)
        {
            var result = FizzBuzzer.FizzBuzz(number);
            Assert.Equal("Buzz", result);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        [InlineData(60)]
        public void ReturnFizzBuzzForMultiplesOf3And5(int number)
        {
            var result = FizzBuzzer.FizzBuzz(number);
            Assert.Equal("FizzBuzz", result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(41)]
        public void FizzBuzz_ShouldReturnStringValue(int number)
        {
            var result = FizzBuzzer.FizzBuzz(number);
            Assert.Equal(number.ToString(), result);
        }

        [Theory]
        [InlineData(101)]
        [InlineData(102)]
        [InlineData(1000)]
        [InlineData(999999)]
        public void ThrowAnExceptionForGreaterValuesThanLimit(int number)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => FizzBuzzer.FizzBuzz(number));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-1000)]
        [InlineData(-999999)]
        public void ThrowAnExceptionForLowerValuesThanLimit(int number)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => FizzBuzzer.FizzBuzz(number));
        }


    }
}