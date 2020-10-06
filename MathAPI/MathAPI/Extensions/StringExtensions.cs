using System;
using System.Text.RegularExpressions;

namespace MathAPI.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNumber(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            Regex regex = new Regex("^-?[0-9]*$");
            if (!regex.IsMatch(value))
                return false;

            return true;
        }

        public static string RemoveNegativeSign(this string value)
        {
            if (value.IsNumber() && value[0].Equals('-'))
                return value.Remove(0, 1);

            return value;
        }
    }
}
