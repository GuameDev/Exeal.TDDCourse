
namespace Exeal.StringCalculator.TDD
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            return numbers.Split(',').Select(x => Convert.ToInt32(x)).Sum(x => x);
        }
    }
}
