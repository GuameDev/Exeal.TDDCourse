
namespace Exeal.LeapYear.TDD
{
    public class LeapYear
    {
        public int Value { get; set; }

        public static LeapYear Create(int year)
        {
            if (!IsValidLeapYear(year))
                throw new InvalidOperationException();

            return new LeapYear() { Value = year };
        }

        private static bool IsValidLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}
