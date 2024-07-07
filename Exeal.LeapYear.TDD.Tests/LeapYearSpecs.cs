namespace Exeal.LeapYear.TDD.Tests
{
    public class LeapYearSpecs
    {
        [Theory]
        [InlineData(2024)]
        [InlineData(2020)]
        [InlineData(2016)]
        [InlineData(2012)]
        public void ReturnALeapYearIfIsDivisibleBy400(int year)
        {
            var result = LeapYear.Create(year);
            Assert.Equal(year, result.Value);
        }

        [Theory]
        [InlineData(1900)]
        [InlineData(1700)]
        [InlineData(1500)]
        [InlineData(1300)]
        public void ThrowInvalidOperationExceptionIfIsDivisibleBy100ButNotBy400(int year)
        {
            Assert.Throws<InvalidOperationException>(() => LeapYear.Create(year));
        }
    }
}