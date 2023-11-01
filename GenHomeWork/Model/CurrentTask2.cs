using GenHomeWork.NumberConvert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenHomeWork.Model
{
    public class CurrentTask2 : TaskBase
    {
        public int numberSystemBase;
        public int numberSysteEnd1;
        public int numberSysteEnd2;
        public int numberFrom;
        public int numberTo;
        public int countTask;
        public int numberDecimalPoint;

        private string FixDecimalPoint(string inputString, int decimalPoint)
        {
            string[] parts = inputString.Split(',');
            string integerPart = parts[0];
            string fractionalPart = parts.Length > 1 ? parts[1] : string.Empty;

            // Форматируем дробную часть с заданным количеством знаков
            if (fractionalPart.Length > decimalPoint)
            {
                fractionalPart = fractionalPart.Substring(0, decimalPoint);
            }
            else
            {
                fractionalPart = fractionalPart.PadRight(decimalPoint, '0');
            }

            // Собираем отформатированную строку
            return integerPart + "." + fractionalPart;
        }

        public void GenerateTasksAndSolutions()
        {
            List<string> tasks = new List<string>();
            List<string> solutions = new List<string>();
            Random random = new Random();
            var flag = true;

            for (int i = 0; i < countTask; i++)
            {
                double randomNumber = random.Next(numberFrom, numberTo) + random.NextDouble();
                int numericSystem;

                do
                {
                    numericSystem = random.Next(numberSysteEnd1, numberSysteEnd2);
                } while (numericSystem == numberSystemBase);

                string baseFromNumber = randomNumber.ToString($"F{numberDecimalPoint}");

                string convertedNumber = NumberConverter.ConvertBase(baseFromNumber, numberSystemBase, numericSystem);

                if (numberDecimalPoint > 0)
                {
                    convertedNumber = FixDecimalPoint(convertedNumber, numberDecimalPoint);
                }

                if (flag)
                {
                    tasks.Add($"\nТип {TemplateManager.CounterType + 1}");
                    solutions.Add($"\nТип {TemplateManager.CounterType + 1}");
                    TemplateManager.CounterType++;
                    flag = false;
                }
                string task = $"{i + 1}. Перевести число {baseFromNumber} с основанием {numberSystemBase} в {numericSystem} систему счисления.";
                string solution = $"{task}\n Решение: {convertedNumber}";

                tasks.Add(task);
                solutions.Add(solution);
            }

            TemplateManager.AddTaskAndSolutionInResultList(tasks, solutions);
        }
    }
}
