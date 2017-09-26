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
                    var a = Double.Parse(numbers.Split(separator.ToCharArray())[0]);
                    var b = Double.Parse(numbers.Split(separator.ToCharArray())[1]);
                    return a + b;
                }
                return Double.Parse(numbers);
            }
            return null;
        }
    }
}