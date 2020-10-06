using System.Text.RegularExpressions;
using MathAPI.Extensions;
using MathAPI.MultipleOf.Interfaces;

namespace MathAPI.MultipleOf
{
    public class MultipleOfEleven : MultipleOf, IMultipleOfEleven
    {
        public override bool IsMultiple(string number)
        {
            if (!number.IsNumber()) return false;

            number = number.RemoveNegativeSign();

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
    }
}
