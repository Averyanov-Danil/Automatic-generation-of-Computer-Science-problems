using GenHomeWork.NumberConvert;
using System;
using System.Collections.Generic;

namespace GenHomeWork.Model
{
    public class CurrentTask3 : TaskBase
    {
        public int num1InitialNumber;
        public int num2InitialNumber;
        public int num1LastNumber;
        public int num2LastNumber;
        public int num1NumDecimalPoints;
        public int num2NumDecimalPoints;
        public int num1InitialSystemNum;
        public int num2InitialSystemNum;
        public int num1LastSystemNum;
        public int num2LastSystemNum;

        public int countTask;

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
                double num1 = random.Next(num1InitialNumber, num1LastNumber) + random.NextDouble();
                int num1NumericSys = random.Next(num1InitialSystemNum, num1LastSystemNum);
                string baseFromNumber1 = num1.ToString($"F{num1NumDecimalPoints}");
                string convertNum1 = NumberConverter.ConvertBase(baseFromNumber1, num1NumericSys, num1NumericSys);
                if (num1NumDecimalPoints > 0)
                {
                     convertNum1 = FixDecimalPoint(convertNum1, num1NumDecimalPoints);
                }

                double num2 = random.Next(num2InitialNumber, num2LastNumber) + random.NextDouble();
                int num2NumericSys = random.Next(num2InitialSystemNum, num2LastSystemNum);
                string baseFromNumber2 = num2.ToString($"F{num2NumDecimalPoints}");
                string convertNum2 = NumberConverter.ConvertBase(baseFromNumber2, num2NumericSys, num2NumericSys);
                if (num2NumDecimalPoints > 0)
                {
                    convertNum2 = FixDecimalPoint(convertNum2, num2NumDecimalPoints);
                }

                string task = $"{i + 1}. Сравните число {convertNum1} в {num1NumericSys} системе счисления, с числом {convertNum2} в {num2NumericSys} системе счисления\n" +
                    $"Используйте знак: >, <, =";
                
                if (flag)
                {
                    tasks.Add($"\nТип {TemplateManager.CounterType + 1}");
                    solutions.Add($"\nТип {TemplateManager.CounterType + 1}");
                    TemplateManager.CounterType++;
                    flag = false;
                }
                string solution;
                if (num1 > num2)
                {
                    solution = $"{task}\n Решение: {convertNum1} ({baseFromNumber1}) > {convertNum2} ({baseFromNumber2})";
                }
                else if (num2 > num1)
                {
                    solution = $"{task}\n Решение: {convertNum1} ({baseFromNumber1}) < {convertNum2} ({baseFromNumber2})";
                }
                else
                {
                    solution = $"{task}\n Решение: {convertNum1} ({baseFromNumber1}) = {convertNum2} ({baseFromNumber2})";
                }

                tasks.Add(task);
                solutions.Add(solution);
            }

            TemplateManager.AddTaskAndSolutionInResultList(tasks, solutions);
        }
    }
}
