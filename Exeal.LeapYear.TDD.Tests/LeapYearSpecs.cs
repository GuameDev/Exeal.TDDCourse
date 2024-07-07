namespace Exeal.LeapYear.TDD.Tests
{
    public class LeapYearSpecs
    {
        [Fact]
        public void ReturnALeapYearIfIsDivisibleBy400()
        {
            var result = LeapYear.Create(2024);
            Assert.Equal(2024, result.Value);
        }

        [Fact]
        public void ReturnALeapYearIfIsDivisibleBy100ButNotBy400()
        {
            var result = LeapYear.Create(1900);
            Assert.Equal(2024, result.Value);
        }
    }
}