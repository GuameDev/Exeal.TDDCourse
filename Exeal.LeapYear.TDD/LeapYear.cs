namespace Exeal.LeapYear.TDD
{
    public class LeapYear
    {
        public int Value { get; }

        private LeapYear(int year)
        {
            Value = year;
        }

        public static LeapYear Create(int year)
        {
            if (!IsValidLeapYear(year))
                throw new InvalidOperationException($"{year} is not a valid leap year.");

            return new LeapYear(year);
        }

        private static bool IsValidLeapYear(int year)
        {
            if (year < 0)
                return false;

            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}
