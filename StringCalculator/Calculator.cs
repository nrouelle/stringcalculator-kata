using System;

namespace StringCalculator
{
    internal class Calculator
    {
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
                return Double.Parse(numbers);
            }
            return null;
        }
    }
}