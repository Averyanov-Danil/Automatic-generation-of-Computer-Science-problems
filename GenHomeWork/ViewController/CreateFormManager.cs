using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GenHomeWork.Model;
using System.Windows.Forms;

namespace GenHomeWork.ViewController
{
    internal class CreateFormManager
    {
        private static DataGridView grid;
        private static List<Model.Template> template;
        public static void FillGridLoad(DataGridView gridTemplate, List<Model.Template> templates)
        {
            grid = gridTemplate;
            template = templates;
            FillGrid();
        }

        private static void FillGrid()
        {
            foreach (var template in template) 
            {
                int rowIndex = grid.Rows.Add();
                grid.Rows[rowIndex].Cells["name"].Value = template.Name;
                grid.Rows[rowIndex].Cells["desc"].Value = $"Кол-во типов задач {template.Tasks.Count}";
            }
        }
    }
}
