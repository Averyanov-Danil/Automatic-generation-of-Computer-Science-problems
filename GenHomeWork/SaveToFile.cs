using Microsoft.Office.Interop.Word;
using System.Collections.Generic;
using System.IO;
namespace GenHomeWork
{
    public class SaveToFile
    {
        public static void SaveToWordFile(string filePath, string title, List<string> content)
        {
            var app = new Application();
            var doc = app.Documents.Add();

            // Заголовок
            var titleRange = doc.Range();
            titleRange.Text = title;
            titleRange.Font.Size = 14;
            titleRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
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
