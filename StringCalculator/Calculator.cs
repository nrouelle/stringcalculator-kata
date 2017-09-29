using System;

namespace StringCalculator
{
    internal class Calculator
    {
        const string separator = ",";
        public Calculator()
        {
        }

        internal double? Add(string numbers)
        {
            if(string.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            else
            {
                if(numbers.Contains(separator))
                {
                    int total = 0;

                    var chars = numbers.Split(separator.ToCharArray());

                    foreach (var number in chars)
                    {
                        total += int.Parse(number);
                    }

                    return total;
                }
                return Double.Parse(numbers);
            }
            return null;
        }
    }
}