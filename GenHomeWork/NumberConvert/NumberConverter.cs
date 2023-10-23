using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenHomeWork.NumberConvert
{
    public static class NumberConverter
    {
        private static int CharToDigit(char c)
        {
            if (char.IsDigit(c))
            {
                return c - '0';
            }
            else if (char.IsLetter(c))
            {
                return char.ToUpper(c) - 'A' + 10;
            }
            else
            {
                throw new ArgumentException("Недопустимый символ в числе.");
            }
        }

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
                int decimalNumber = 0;
                int power = 1;

                // Переводим число из исходной системы в десятичную
                for (int i = number.Length - 1; i >= 0; i--)
                {
                    decimalNumber += CharToDigit(number[i]) * power;
                    power *= baseFrom;
                }

                // Переводим число из десятичной системы в целевую
                StringBuilder result = new StringBuilder();
                while (decimalNumber > 0)
                {
                    int remainder = decimalNumber % baseTo;
                    result.Insert(0, DigitToChar(remainder));
                    decimalNumber /= baseTo;
                }

                return result.ToString();
            }
            catch (ArgumentException)
            {
                return "Ошибка: недопустимые символы в числе или недопустимая система счисления";
            }
        }
    }
}
