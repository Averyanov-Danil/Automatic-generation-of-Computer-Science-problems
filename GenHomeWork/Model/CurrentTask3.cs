using GenHomeWork.NumberConvert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void GenerateTasksAndSolutions()
        {
            List<string> tasks = new List<string>();
            List<string> solutions = new List<string>();
            Random random = new Random();

            for (int i = 0; i < countTask; i++)
            {
                double num1 = random.Next(num1InitialNumber, num1LastNumber) + random.NextDouble();
                int num1NumericSys = random.Next(num1InitialSystemNum, num1LastSystemNum);
                string baseFromNumber1 = num1.ToString($"F{num1NumDecimalPoints}");
                string convertNum1 = NumberConverter.ConvertBase(baseFromNumber1, num1NumericSys, num1NumericSys);
                if (num1NumDecimalPoints > 0)
                {
                    double.TryParse(convertNum1, out double res);
                    var r = Math.Round(res, num1NumDecimalPoints);
                    convertNum1 = r.ToString();
                }

                double num2 = random.Next(num2InitialNumber, num2LastNumber) + random.NextDouble();
                int num2NumericSys = random.Next(num2InitialSystemNum, num2LastSystemNum);
                string baseFromNumber2 = num2.ToString($"F{num2NumDecimalPoints}");
                string convertNum2 = NumberConverter.ConvertBase(baseFromNumber2, num2NumericSys, num2NumericSys);
                if (num2NumDecimalPoints > 0)
                {
                    double.TryParse(convertNum2, out double res);
                    var r = Math.Round(res, num2NumDecimalPoints);
                    convertNum2 = r.ToString();
                }

                string task = $"{i + 1}. Сравните число {convertNum1} в {num1NumericSys} системе счисления, с числом {convertNum2} в {num2NumericSys} системе счисления\n" +
                    $"Используйте знак: >, <, =";
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
