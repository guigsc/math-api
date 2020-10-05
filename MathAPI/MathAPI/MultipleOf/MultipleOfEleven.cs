using System.Text.RegularExpressions;
using MathAPI.MultipleOf.Interfaces;

namespace MathAPI.MultipleOf
{
    public class MultipleOfEleven : MultipleOf, IMultipleOfEleven
    {
        public override bool IsMultiple(string number)
        {
            if (!IsValidNumber(number))
                return false;
            
            if (number[0].Equals('-'))
                number = number.Remove(0, 1);
            
            int sumOddDigits = 0, sumEvenDigits = 0;

            for (int digitIndex = 0; digitIndex < number.Length; digitIndex++)
            {
                if (digitIndex % 2 == 0) 
                    sumOddDigits += number[digitIndex] - '0';
                else
                    sumEvenDigits += number[digitIndex] - '0';
            }

            bool isMultiple = (sumOddDigits - sumEvenDigits) % 11 == 0;

            return isMultiple;
        }

        private bool IsValidNumber(string number)
        {
            if (string.IsNullOrEmpty(number)) return false;

            Regex regex = new Regex("^-?[0-9]*$");
            if (!regex.IsMatch(number)) return false;

            return true;
        }
    }
}
