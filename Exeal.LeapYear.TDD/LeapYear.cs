
namespace Exeal.LeapYear.TDD
{
    public class LeapYear
    {
        public int Value { get; set; }

        public static LeapYear Create(int year)
        {
            return new LeapYear() { Value = year };
        }
    }
}
