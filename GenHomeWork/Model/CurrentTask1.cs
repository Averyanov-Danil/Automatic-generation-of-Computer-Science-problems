using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Office.Interop.Word;
using System.Numerics;
using System.Globalization;
using GenHomeWork.NumberConvert;
using System.IO;

namespace GenHomeWork.Model
{
    [Serializable]
    internal class CurrentTask1 : TaskBase
    {
        public int numberSystemBase;
        public int numberSysteEnd1;
        public int numberSysteEnd2;
        public int numberFrom;
        public int numberTo;
        public int countTask;

        /// <summary>
        /// Генерация задачи и ее решение, а так же сохранение их в листы для дальнейшей печати в файл
        /// </summary>
        /// <param name="savePath"></param>
        /// <param name="solutionsPath"></param>
        public void GenerateAndSaveTasks()
        {
            Random random = new Random();

            List<string> tasks = new List<string>();
            List<string> solutions = new List<string>();

            for (int i = 0; i < countTask; i++)
            {
                int number = random.Next(numberFrom, numberTo + 1);
                int baseFrom = numberSystemBase;
                int baseTo;

                do
                {
                    baseTo = random.Next(numberSysteEnd1, numberSysteEnd2 + 1);
                } while (baseTo == baseFrom);

                // Генерация задачи
                string taskText = $"{i + 1}. Перевести {number} из {baseFrom}-ой системы счисления в {baseTo}-ую систему счисления.";
                tasks.Add(taskText);

                // Генерация решения
                string solutionText = $"{taskText}\nРешение: {NumberConverter.ConvertBase(number.ToString(), baseFrom, baseTo)} в {baseTo}-ой системе.";
                solutions.Add(solutionText);
            }
            
            TemplateManager.AddTaskAndSolutionInResultList(tasks, solutions);
        }
    }
}
