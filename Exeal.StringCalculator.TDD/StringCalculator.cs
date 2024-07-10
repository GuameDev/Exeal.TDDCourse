
namespace Exeal.StringCalculator.TDD
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            ICollection<char> separators = [',', '\n'];

            if (!numbers.StartsWith("//"))
                return numbers.Split(separators.ToArray()).Select(x => Convert.ToInt32(x)).Sum(x => x);


            separators.Add(numbers[2]);
            return numbers.Substring(3).Split(separators.ToArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).Sum(x => x);

        }
    }
}
