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

        public void GenerateTasksAndSolutions()
        {
            List<string> tasks = new List<string>();
            List<string> solutions = new List<string>();
            Random random = new Random();

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

                string task = $"{i + 1}. Перевести число {baseFromNumber} с основанием {numberSystemBase} в {numericSystem} систему счисления.";
                string solution = $"{task}\n Решение: {convertedNumber}";

                tasks.Add(task);
                solutions.Add(solution);
            }

            TemplateManager.AddTaskAndSolutionInResultList(tasks, solutions);
        }
    }
}
