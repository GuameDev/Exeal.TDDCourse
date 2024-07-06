namespace Exeal.FizzBuzz.TDD
{
    public class FizzBuzzer
    {
        public static string FizzBuzz(int number)
        {
            if (IsOutOfRange(number)) throw new ArgumentOutOfRangeException(nameof(number), $"{number} is out of range. Valid range is {FizzBuzzConstants.MinValue} to {FizzBuzzConstants.MaxValue}.");

            return number switch
            {
                _ when IsDivisibleBy(number, FizzBuzzConstants.FizzMultiple) && IsDivisibleBy(number, FizzBuzzConstants.BuzzMultiple) => FizzBuzzConstants.FizzBuzz,
                _ when IsDivisibleBy(number, FizzBuzzConstants.BuzzMultiple) => FizzBuzzConstants.Buzz,
                _ when IsDivisibleBy(number, FizzBuzzConstants.FizzMultiple) => FizzBuzzConstants.Fizz,
                _ => number.ToString()
            };
        }

        private static bool IsOutOfRange(int value) => value > FizzBuzzConstants.MaxValue || value < FizzBuzzConstants.MinValue;

        private static bool IsDivisibleBy(int value, int divisor) => value % divisor == 0;
    }
}
