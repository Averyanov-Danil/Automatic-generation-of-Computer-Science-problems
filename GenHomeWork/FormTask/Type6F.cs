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
    public partial class Type6F : Form
    {
        private int moreOrLess;
        private int numericSystem;
        private Random rand = new Random();

        CreateForm CreateForm;

        public Type6F(CreateForm form)
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

        private void rbtnMoreOrLess_CheckedChanged(object sender, EventArgs e)
        {
            var rbtn = (RadioButton)sender;
            if (rbtn.Checked && rbtn.Name == "rbtnMore")
            {
                moreOrLess = 1;
            }
            else if (rbtn.Checked && rbtn.Name == "rbtnLess")
            {
                moreOrLess = 2;
            }
            else if (rbtn.Checked && rbtn.Name == "rbtnMoreOrLess")
            {
                moreOrLess = 0;
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            CurrentTask6 task = new CurrentTask6()
            {
                Type = "Task6",
                moreOrLess = moreOrLess,

                initialNum = (int)initialNum.Value,
                lastNum = (int)lastNum.Value,
                numericSystem = numericSystem,

                countTask = (int)nudCount.Value,
            };

            TemplateManager.AddTask(task);

            MessageBox.Show("Задачи были добавлены.\nПосле добавленя последний задачи, пожалуйста, создайте " +
                "шаблон!\nНеобходимо указаать его имя(оно должно быть уникальным) и нажать соответствующую кнопку");

            CreateForm.VisabilityCreatePatternElements(CreateForm.lblNamePattern, CreateForm.tbNamePattern, CreateForm.btnCreatePattern);
        }
    }
}
