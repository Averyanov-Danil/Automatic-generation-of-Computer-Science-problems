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
    public partial class TypeOneF : Form
    {
        private int numSys1 = 0;
        private int numSys2 = 0;
        private int start = 0;
        private int end = 0;
        private int numSys3 = 0;
        private int countTask = 0;

        public TypeOneF()
        {
            InitializeComponent();

            rbtnDouble.CheckedChanged += rbtn_SelectedIntOrDouble;
            rbtnInt.CheckedChanged += rbtn_SelectedIntOrDouble;
            panelDouble.Visible = false;
            panelInt.Visible = false;
        }

        #region Оработка смены значения
        private void nudStart_ValueChanged(object sender, EventArgs e)
        {
            start = (int)nudStart.Value;
            lblEndTask.Text = $"Итог:\r\nПеревести ( {"От " + start + " до " + end} ) с основанием {numSys1}  в {"От " + numSys2 + " до " + numSys3} систему счисления.";
        }

        private void nudEnd_ValueChanged(object sender, EventArgs e)
        {
            end = (int)nudEnd.Value;
            lblEndTask.Text = $"Итог:\r\nПеревести ( {"От " + start + " до " + end} ) с основанием {numSys1}  в {"От " + numSys2 + " до " + numSys3} систему счисления.";
        }

        private void nudCC1_ValueChanged(object sender, EventArgs e)
        {
            numSys1 = (int)numberSys1.Value;
            lblEndTask.Text = $"Итог:\r\nПеревести ( {"От " + start + " до " + end} ) с основанием {numSys1}  в {"От " + numSys2 + " до " + numSys3} систему счисления.";
        }

        private void nudCC2_ValueChanged(object sender, EventArgs e)
        {
            numSys2 = (int)numberSys2.Value;
            lblEndTask.Text = $"Итог:\r\nПеревести ( {"От " + start + " до " + end} ) с основанием {numSys1}  в {"От " + numSys2 + " до " + numSys3} систему счисления.";
        }

        private void numberSys3_ValueChanged(object sender, EventArgs e)
        {
            numSys3 = (int)numberSys3.Value;
            lblEndTask.Text = $"Итог:\r\nПеревести ( {"От " + start + " до " + end} ) с основанием {numSys1}  в {"От " + numSys2 + " до " + numSys3} систему счисления.";
        }
        #endregion

        private void rbtn_SelectedIntOrDouble(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked && radioButton.Name == "rbtnDouble")
            {
                panelInt.Visible = false;
                panelDouble.Visible = true;
                panelDouble.Location = new Point(panelInt.Location.X, panelInt.Location.Y);
            }
            else if (radioButton.Checked && radioButton.Name == "rbtnInt")
            {
                panelInt.Visible = true;
                panelDouble.Visible = false;
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            countTask = (int)nudCount.Value;

            CurrentTaskOne task = new CurrentTaskOne
            {
                Type = "TaskOne",
                
                numberFrom = start,
                numberTo = end,
                countTask = countTask,
                numberSystemBase = numSys1,
                numberSysteEnd1 = numSys2,
                numberSysteEnd2 = numSys3,
            };
            TemplateManager.AddTask(task);

            MessageBox.Show("Задачи были добавлены.\nПосле добавленя последний задачи, пожалуйста, создайте " +
                "шаблон!\nНеобходимо указаать его имя(оно должно быть уникальным) и нажать соответствующую кнопку");
        }
    }
}
