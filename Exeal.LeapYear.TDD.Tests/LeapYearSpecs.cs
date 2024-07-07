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
            Assert.Throws<InvalidOperationException>(() => LeapYear.Create(1900));
        }
    }
}