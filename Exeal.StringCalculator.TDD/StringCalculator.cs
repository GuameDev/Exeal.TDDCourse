
namespace Exeal.StringCalculator.TDD
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            char[] separators = [',', '\n'];
            return numbers.Split(separators).Select(x => Convert.ToInt32(x)).Sum(x => x);
        }
    }
}
