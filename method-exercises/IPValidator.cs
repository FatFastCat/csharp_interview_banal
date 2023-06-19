using System;
namespace method_exercises
{
    public static class IPValidator
    {
        public static bool ValidateLength(string[] address)
        {
            return address.Length == 4;
        }

        public static bool ValidateZeroes(string[] address)
        {
            foreach (string number in address)
            {
                if (number.Length > 1 && number.StartsWith("0"))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool ValidateRange(string[] address)
        {
            foreach (string number in address)
            {
                if (int.Parse(number) > 255)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

