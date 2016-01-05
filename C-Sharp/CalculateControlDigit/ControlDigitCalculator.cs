using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateControlDigit
{
    internal static class ControlDigitCalculator
    {
        internal static Tuple<int?, string> ParseAndCalculate(string input)
        {
            int inputNumber;
            if (int.TryParse(input, out inputNumber))
            {
                return CheckAndCalculate(inputNumber);
            }
            else
            {
                return new Tuple<int?, string>(null, "Unable to parse the input!");
            }
        }

        private static Tuple<int?, string> CheckAndCalculate(int inputNumber)
        {
            if (inputNumber < 0)
            {
                return new Tuple<int?, string>(null, "The input number must be positive!");
            }

            var result = Calculate(inputNumber);

            return new Tuple<int?, string>(result, "");
        }

        private static int Calculate(int inputNumber)
        {
            var sum = 0;
            var pos = 0;

            var digits = GetDigits(inputNumber);

            foreach (var digit in digits)
            {
                int value;
                if (pos % 2 == 0)
                {
                    value = 3 * digit;
                }
                else
                {
                    value = digit;
                }

                sum += value;
            }

            var result = sum % 11;

            if (result == 10)
            {
                result = 1;
            }

            return result;
        }

        private static IEnumerable<int> GetDigits(int number)
        {
            var digits = new List<int>();

            do
            {
                var digit = number % 10;

                digits.Add(digit);

                number /= 10;
            } while (number > 0);
            return digits;
        }
    }
}
