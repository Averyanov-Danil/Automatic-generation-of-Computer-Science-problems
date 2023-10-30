using GenHomeWork.Model;
using Microsoft.Office.Interop.Word;
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
    public partial class Type4F : Form
    {
        int numericSystem;
        CreateForm form;

        public Type4F(CreateForm createForm)
        {
            InitializeComponent();
            form = createForm;
        }

        private void rbtnCC_CheckedChanged(object sender, EventArgs e)
        {
            var rbtn = (RadioButton)sender;
            if (rbtn.Checked && rbtn.Name == "rbtnC8") { numericSystem = 8; }
            else if (rbtn.Checked && rbtn.Name == "rbtnC10") { numericSystem = 10; }
            else if (rbtn.Checked && rbtn.Name == "rbtnC16") { numericSystem = 16; }
            else if (rbtn.Checked && rbtn.Name == "rbtnCRandom") { numericSystem = 0; }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            CurrentTask4 task = new CurrentTask4()
            {
                Type = "Task4",
                initialNumber = (int)initialNum.Value,
                lastNumber = (int)lastNum.Value,
                initialNumericSystem = numericSystem,

                countTask = (int)nudCount.Value,
            };

            TemplateManager.AddTask(task);

            MessageBox.Show("Задачи были добавлены.\nПосле добавленя последний задачи, пожалуйста, создайте " +
                "шаблон!\nНеобходимо указаать его имя(оно должно быть уникальным) и нажать соответствующую кнопку");

            form.VisabilityCreatePatternElements(form.lblNamePattern, form.tbNamePattern, form.btnCreatePattern);
        }

        private void nudCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
