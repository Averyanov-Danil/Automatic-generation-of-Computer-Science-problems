using GenHomeWork.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenHomeWork.FormTask
{
    public partial class Type5F : Form
    {
        CreateForm CreateForm;
        public Type5F(CreateForm form)
        {
            InitializeComponent();
            CreateForm = form;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            CurrentTask5 task = new CurrentTask5()
            {
                Type = "Task5",

                initialNum = (int)initialNum.Value,
                lastNum = (int)lastNum.Value,

                initialNumericSystem1 = (int)initialSystemNumeric1.Value,
                lastNumericSystem1 = (int)lastSystemNumeric1.Value,

                initialNumericSystem2 = (int)initialSystemNumeric2.Value,
                lastNumericSystem2 = (int)lastSystemNumeric2.Value,

                countTask = (int)countTask.Value
            };

            TemplateManager.AddTask(task);

            MessageBox.Show("Задачи были добавлены.\nПосле добавленя последний задачи, пожалуйста, создайте " +
                "шаблон!\nНеобходимо указаать его имя(оно должно быть уникальным) и нажать соответствующую кнопку");

            CreateForm.VisabilityCreatePatternElements(CreateForm.lblNamePattern, CreateForm.tbNamePattern, CreateForm.btnCreatePattern);
        }
    }
}
