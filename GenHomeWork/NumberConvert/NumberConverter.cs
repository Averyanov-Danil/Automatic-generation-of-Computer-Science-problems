using System;
using System.Text;

namespace GenHomeWork.NumberConvert
{
    public static class NumberConverter
    {
        private static char DigitToChar(int digit)
        {
            if (digit >= 0 && digit <= 9)
            {
                return (char)('0' + digit);
            }
            else if (digit >= 10 && digit <= 15)
            {
                return (char)('A' + digit - 10);
            }
            else
            {
                throw new ArgumentException("Недопустимая цифра.");
            }
        }

        public static string ConvertBase(string number, int baseFrom, int baseTo)
        {
            try
            {
                double decimalNumber = 0;
                bool hasFractionalPart = false;

                for (int i = 0; i < number.Length; i++)
                {
                    char c = number[i];

                    if (char.IsDigit(c))
                    {
                        decimalNumber = decimalNumber * baseFrom + char.GetNumericValue(c);
                        if (hasFractionalPart)
                        {
                            hasFractionalPart = false;
                        }
                    }
                    else if (c == '.')
                    {
                        hasFractionalPart = true;
                    }
                    else
                    {
                        throw new ArgumentException("Недопустимый символ в числе.");
                    }
                }

                if (hasFractionalPart)
                {
                    throw new ArgumentException("Недопустимая десятичная точка в числе.");
                }

                StringBuilder result = new StringBuilder();

                int integerPart = (int)decimalNumber;
                double fractionalPart = decimalNumber - integerPart;

                while (integerPart > 0)
                {
                    int remainder = integerPart % baseTo;
                    result.Insert(0, DigitToChar(remainder));
                    integerPart /= baseTo;
                }

                if (result.Length == 0)
                {
                    result.Append('0');
                }

                if (fractionalPart > 0)
                {
                    result.Append('.');

                    for (int i = 0; i < 10; i++) // Limit the number of decimal places to 10
                    {
                        fractionalPart *= baseTo;
                        int intPart = (int)fractionalPart;
                        result.Append(DigitToChar(intPart));
                        fractionalPart -= intPart;
                    }
                }

                return result.ToString();
            }
            catch (ArgumentException ex)
            {
                return "Ошибка: " + ex.Message;
            }
        }
    }
}
