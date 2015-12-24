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
                return Calculate(inputNumber);
            }
            else
            {
                return new Tuple<int?, string>(null, "Unable to parse the input!");
            }
        }

        internal static Tuple<int?, string> Calculate(int inputNumber)
        {
            if (inputNumber < 0)
            {
                return new Tuple<int?, string>(null, "The input number must be positive!");
            }

            var number = inputNumber;
            var sum = 0;
            var pos = 0;

            do
            {
                var digit = inputNumber % 10;

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

                number /= 10;
            } while (number > 0);

            var result = sum % 11;

            if (result == 10)
            {
                result = 1;
            }

            return new Tuple<int?, string>(result, "");
        }
    }
}
