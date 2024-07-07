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
    }
}