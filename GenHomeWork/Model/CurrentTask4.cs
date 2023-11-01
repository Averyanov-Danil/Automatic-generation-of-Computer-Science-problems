using GenHomeWork.NumberConvert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenHomeWork.Model
{
    public class CurrentTask4 : TaskBase
    {
        public int initialNumericSystem;
        public int initialNumber;
        public int lastNumber;

        public int countTask;

        public void GenerateTasksAndSolutions()
        {
            var tasks = new List<string>();
            var solutions = new List<string>();
            Random random = new Random();
            var flag = true;

            for (int i = 0; i < countTask; i++)
            {
                int number = random.Next(initialNumber, lastNumber);
                int numericSys = initialNumericSystem;
                int count = random.Next(0, 2);
                if (numericSys == 0)
                {
                    var ch = random.Next(1, 4);
                    if (ch == 1) { numericSys = 8; }
                    else if (ch == 2) { numericSys = 16; }
                    else if (ch == 3) {  numericSys = 10; }
                }

                var binaryNum = NumberConverter.ConvertBase(number.ToString(), 10, 2);
                var baseNumber = NumberConverter.ConvertBase(number.ToString(), 10, numericSys);

                if (count == 0)
                {
                    if (flag)
                    {
                        tasks.Add($"\nТип {TemplateManager.CounterType + 1}");
                        solutions.Add($"\nТип {TemplateManager.CounterType + 1}");
                        TemplateManager.CounterType++;
                        flag = false;
                    }
                    var task = $"{i + 1}. Сколько значащих нулей в двоичной записи числа {baseNumber} с основанием {numericSys}?";
                    var solution = $"{task}\nРешение: {binaryNum.Count(c => c == '0')} (В 2ичной - {binaryNum})";
                    tasks.Add(task);
                    solutions.Add(solution);
                }
                else if (count == 1)
                {
                    if (flag)
                    {
                        tasks.Add($"Тип {TemplateManager.CounterType + 1}");
                        solutions.Add($"Тип {TemplateManager.CounterType + 1}");
                        TemplateManager.CounterType++;
                        flag = false;
                    }
                    var task = $"{i + 1}. Сколько единиц в двоичной записи числа {baseNumber} с основанием {numericSys}?";
                    var solution = $"{task}\nРешение: {binaryNum.Count(c => c == '1')} (В 2ичной - {binaryNum})";
                    tasks.Add(task);
                    solutions.Add(solution);
                }
            }

            TemplateManager.AddTaskAndSolutionInResultList(tasks, solutions);
        }
    }
}
