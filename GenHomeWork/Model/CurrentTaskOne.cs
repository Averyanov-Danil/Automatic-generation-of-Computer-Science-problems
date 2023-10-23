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
    internal class CurrentTaskOne : TaskBase
    {
        public int numberSystemBase;
        public int numberSysteEnd1;
        public int numberSysteEnd2;
        public int numberFrom;
        public int numberTo;
        public int countTask;

        // Генерация и сохранение задачи
        public void GenerateAndSaveTasks(string savePath, string solutionsPath)
        {
            Random random = new Random();

            List<string> tasks = new List<string>();
            List<string> solutions = new List<string>();

            for (int i = 0; i < countTask; i++)
            {
                int number = random.Next(numberFrom, numberTo + 1);
                int baseFrom = numberSystemBase;
                int baseTo = random.Next(numberSysteEnd1, numberSysteEnd2 + 1);

                // Генерация задачи
                string taskText = $"Перевести {number} из {baseFrom}-ой системы счисления в {baseTo}-ую систему счисления.";
                tasks.Add(taskText);

                // Генерация решения
                string solutionText = $"{taskText}\nРешение: {NumberConverter.ConvertBase(number.ToString(), baseFrom, baseTo)} в {baseTo}-ой системе.";
                solutions.Add(solutionText);
            }

            // Сохранение задач в файл Word
            SaveToWordFile(savePath, "Задачи", tasks);

            // Сохранение решений в файл Word
            SaveToWordFile(solutionsPath, "Решения", solutions);
        }

        // Метод для сохранения текста в файл Word
        private void SaveToWordFile(string filePath, string title, List<string> content)
        {
            var app = new Application();
            var doc = app.Documents.Add();

            // Заголовок
            var titleRange = doc.Range();
            titleRange.Text = title;
            titleRange.Font.Size = 14;
            titleRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            titleRange.InsertParagraphAfter();

            // Задачи/Решения
            foreach (string text in content)
            {
                var paragraph = doc.Paragraphs.Add(); // Создаем новый параграф
                paragraph.Range.Text = text; // Устанавливаем текст в параграф
                paragraph.Range.InsertParagraphAfter(); // Добавляем новый параграф
            }

            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            doc.SaveAs2(filePath);
            doc.Close();
            app.Quit();
        }
    }
}
