using GenHomeWork.NumberConvert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenHomeWork.Model
{
    public class CurrentTask5 : TaskBase
    {
        public int initialNum;
        public int lastNum;
        public int initialNumericSystem1;
        public int initialNumericSystem2;
        public int lastNumericSystem1;
        public int lastNumericSystem2;
        
        public int countTask;

        public void GenerateTasksAndSolutions()
        {
            var tasks = new List<string>();
            var solutions = new List<string>();
            Random random = new Random();
            var flag = true;

            for (int i = 0; i < countTask; i++)
            {
                var intervalNumber = random.Next(2, 13);
                var number1 = random.Next(initialNum, lastNum);
                var number2 = number1 + intervalNumber;

                var numSys1 = random.Next(initialNumericSystem1, lastNumericSystem1 + 1);
                var numSys2 = random.Next(initialNumericSystem2, lastNumericSystem2 + 1);

                var convertNum1 = NumberConverter.ConvertBase(number1.ToString(), 10, numSys1);
                var convertNum2 = NumberConverter.ConvertBase(number2.ToString(), 10, numSys2);

                if (flag)
                {
                    tasks.Add($"Тип {TemplateManager.CounterType + 1}");
                    solutions.Add($"Тип {TemplateManager.CounterType + 1}");
                    TemplateManager.CounterType++;
                    flag = false;
                }

                var task = $"{i + 1}. Сколько чисел находится между {convertNum1} в {numSys1} системе счисления и {convertNum2} в {numSys2} системе счисления?";
                var solution = $"{task}\nРешение: {number2 - number1 - 1} ({number1} --- {number2})";

                tasks.Add(task);
                solutions.Add(solution);
            }
            TemplateManager.AddTaskAndSolutionInResultList(tasks, solutions);
        }
    }
}
