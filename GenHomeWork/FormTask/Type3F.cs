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
    public partial class Type3F : Form
    {
        CreateForm CreateForm;

        public Type3F(CreateForm form)
        {
            InitializeComponent();

            CreateForm = form;

            num1ValuePoints.Visible = false;
            num2ValuePoints.Visible = false;
        }

        private void num1ValuePointsChecked_CheckedChanged(object sender, EventArgs e)
        {
            if (num1ValuePointsChecked.Checked)
            {
                num1ValuePoints.Visible = true;
            }
            else
            {
                num1ValuePoints.Visible= false;
            }
        }

        private void num2ValuePointsChecked_CheckedChanged(object sender, EventArgs e)
        {
            if (num2ValuePointsChecked.Checked)
            {
                num2ValuePoints.Visible = true;
            }
            else
            {
                num2ValuePoints.Visible = false;
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            int numValPo = 0;
            int numValPo2 = 0;
            if (num1ValuePointsChecked.Checked)
            {
                numValPo = (int)num1NumDecimalPoints.Value;
            }
            if (num2ValuePointsChecked.Checked)
            {
                numValPo2 = (int)num2NumDecimalPoints.Value;
            }

            CurrentTask3 task = new CurrentTask3
            {
                Type = "Task3",
                num1InitialNumber = (int)num1InitialNum.Value,
                num1LastNumber = (int)num1LastNum.Value,
                num1InitialSystemNum = (int)num1InitialSystemNum.Value,
                num1LastSystemNum = (int)num1LastSystemNum.Value,
                num1NumDecimalPoints = numValPo,
                num2InitialNumber = (int)num2InitialNum.Value,
                num2LastNumber = (int)num2LastNum.Value,
                num2InitialSystemNum = (int)num2InitialSystemNum.Value,
                num2LastSystemNum = (int)num2LastSystemNum.Value,
                num2NumDecimalPoints = numValPo2,

                countTask = (int)nudCount.Value
            };
            TemplateManager.AddTask(task);

            MessageBox.Show("Задачи были добавлены.\nПосле добавленя последний задачи, пожалуйста, создайте " +
                "шаблон!\nНеобходимо указаать его имя(оно должно быть уникальным) и нажать соответствующую кнопку");

            CreateForm.VisabilityCreatePatternElements(CreateForm.lblNamePattern, CreateForm.tbNamePattern, CreateForm.btnCreatePattern);
        }
    }
}
