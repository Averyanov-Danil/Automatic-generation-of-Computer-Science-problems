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
    public partial class Type7F : Form
    {
        private int numericSystem;
        private int numericSystem2;
        private int numericSystem3;

        CreateForm CreateForm;

        public Type7F(CreateForm form)
        {
            InitializeComponent();

            CreateForm = form;
        }

        private void rbtnCRandom_CheckedChanged(object sender, EventArgs e)
        {
            var rbtn = (RadioButton)sender;
            if (rbtn.Checked && rbtn.Name == "rbtnC2")
            {
                numericSystem = 2;
            }
            else if (rbtn.Checked && rbtn.Name == "rbtnC8")
            {
                numericSystem = 8;
            }
            else if (rbtn.Checked && rbtn.Name == "rbtnC16")
            {
                numericSystem = 16;
            }
            else if (rbtn.Checked && rbtn.Name == "rbtnCRandom")
            {
                numericSystem = 0;
            }
        }

        private void rbtn2cRandom_CheckedChanged(object sender, EventArgs e)
        {
            var rbtn = (RadioButton)sender;
            if (rbtn.Checked && rbtn.Name == "rbtn2c2")
            {
                numericSystem2 = 2;
            }
            else if (rbtn.Checked && rbtn.Name == "rbtn2c8")
            {
                numericSystem2 = 8;
            }
            else if (rbtn.Checked && rbtn.Name == "rbtn2c16")
            {
                numericSystem2 = 16;
            }
            else if (rbtn.Checked && rbtn.Name == "rbtn2cRandom")
            {
                numericSystem2 = 0;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var rbtn = (RadioButton)sender;
            if (rbtn.Checked && rbtn.Name == "rbtn3c2")
            {
                numericSystem3 = 2;
            }
            else if (rbtn.Checked && rbtn.Name == "rbtn3c8")
            {
                numericSystem3 = 8;
            }
            else if (rbtn.Checked && rbtn.Name == "rbtn3c16")
            {
                numericSystem3 = 16;
            }
            else if (rbtn.Checked && rbtn.Name == "rbtn3cRandom")
            {
                numericSystem3 = 0;
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            CurrentTask7 task = new CurrentTask7()
            {
                Type = "Task7",
                initialNumber = (int)initialNum.Value,
                lastNumber = (int)lastNum.Value,

                numericSystem1 = numericSystem,
                numericSystem2 = numericSystem2,
                numericSystem3 = numericSystem3,

                countTask = (int)nudCount.Value
            };

            TemplateManager.AddTask(task);

            MessageBox.Show("Задачи были добавлены.\nПосле добавленя последний задачи, пожалуйста, создайте " +
                "шаблон!\nНеобходимо указаать его имя(оно должно быть уникальным) и нажать соответствующую кнопку");

            CreateForm.VisabilityCreatePatternElements(CreateForm.lblNamePattern, CreateForm.tbNamePattern, CreateForm.btnCreatePattern);
        }
    }
}
