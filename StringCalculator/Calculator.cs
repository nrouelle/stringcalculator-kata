using System;

namespace StringCalculator
{
    internal class Calculator
    {
        const string separator = ",";
        string[] stringSeparators = new string[] { ",", "\n" };
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
                if(numbers.Contains(stringSeparators[0]) || numbers.Contains(stringSeparators[1]))
                {
                    int total = 0;

                    var chars = numbers.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

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