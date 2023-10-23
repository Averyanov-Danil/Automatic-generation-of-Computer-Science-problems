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
        }
    }
}
