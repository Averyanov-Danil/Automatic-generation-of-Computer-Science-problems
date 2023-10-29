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
        private int mainInitialNumericSystem;
        private int mainLastNumericSystem;
        private int initialNumericSystem;
        private int initialNumber;
        private int lastNumber;
        private int lastNumericSystem;
        private int countTask;

        public CreateForm CreateForm;

        private Random random = new Random();

        public TypeOneF(CreateForm form)
        {
            InitializeComponent();

            CreateForm = form;

            rbtnDouble.CheckedChanged += rbtn_SelectedIntOrDouble;
            rbtnInt.CheckedChanged += rbtn_SelectedIntOrDouble;
            panelC1.Visible = false;
            numDecimalPoints.Visible = false;
            label4.Visible = false;

            mainInitialNumericSystem = (int)mainInitialNumSystem.Value;
            mainLastNumericSystem = (int)mainLastNumSystem.Value;
            initialNumericSystem = (int)initialNumSystem.Value;
            initialNumber = (int)initialNum.Value;
            lastNumber = (int)lastNum.Value;
            lastNumericSystem = (int)lastNumSystem.Value;
            countTask = (int)nudCount.Value;

            lblEndTask.Text = $"Итог:\r\nПеревести ( {"От " + initialNumber + " до " + lastNumber} ) с основанием {"От " + mainInitialNumericSystem + " до " + mainLastNumericSystem}  в {"От " + initialNumericSystem + " до " + lastNumericSystem} систему счисления.";
        }

        #region Оработка смены значения
        private void initialNum_ValueChanged(object sender, EventArgs e)
        {
            initialNumber = (int)initialNum.Value;
            lblEndTask.Text = $"Итог:\r\nПеревести ( {"От " + initialNumber + " до " + lastNumber} ) с основанием {"От " + mainInitialNumericSystem + " до " + mainLastNumericSystem}  в {"От " + initialNumericSystem + " до " + lastNumericSystem} систему счисления.";
        }

        private void lastNum_ValueChanged_1(object sender, EventArgs e)
        {
            lastNumber = (int)lastNum.Value;
            lblEndTask.Text = $"Итог:\r\nПеревести ( {"От " + initialNumber + " до " + lastNumber} ) с основанием {"От " + mainInitialNumericSystem + " до " + mainLastNumericSystem}  в {"От " + initialNumericSystem + " до " + lastNumericSystem} систему счисления.";
        }

        private void mainInitialNumSystem_ValueChanged(object sender, EventArgs e)
        {
            mainInitialNumericSystem = (int)mainInitialNumSystem.Value;
            lblEndTask.Text = $"Итог:\r\nПеревести ( {"От " + initialNumber + " до " + lastNumber} ) с основанием {"От " + mainInitialNumericSystem + " до " + mainLastNumericSystem}  в {"От " + initialNumericSystem + " до " + lastNumericSystem} систему счисления.";
        }

        private void nudCC2_ValueChanged(object sender, EventArgs e)
        {
            initialNumericSystem = (int)initialNumSystem.Value;
            lblEndTask.Text = $"Итог:\r\nПеревести ( {"От " + initialNumber + " до " + lastNumber} ) с основанием {"От " + mainInitialNumericSystem + " до " + mainLastNumericSystem}  в {"От " + initialNumericSystem + " до " + lastNumericSystem} систему счисления.";
        }

        private void numberSys3_ValueChanged(object sender, EventArgs e)
        {
            lastNumericSystem = (int)lastNumSystem.Value;
            lblEndTask.Text = $"Итог:\r\nПеревести ( {"От " + initialNumber + " до " + lastNumber} ) с основанием {"От " + mainInitialNumericSystem + " до " + mainLastNumericSystem}  в {"От " + initialNumericSystem + " до " + lastNumericSystem} систему счисления.";
        }

        private void mainLastNumSystem_ValueChanged(object sender, EventArgs e)
        {
            mainLastNumericSystem = (int)mainLastNumSystem.Value;
            lblEndTask.Text = $"Итог:\r\nПеревести ( {"От " + initialNumber + " до " + lastNumber} ) с основанием {"От " + mainInitialNumericSystem + " до " + mainLastNumericSystem}  в {"От " + initialNumericSystem + " до " + lastNumericSystem} систему счисления.";
        }
        #endregion

        private void rbtn_SelectedIntOrDouble(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked && radioButton.Name == "rbtnDouble")
            {
                numDecimalPoints.Visible = true;
                label4.Visible = true;
            }
            else if (radioButton.Checked && radioButton.Name == "rbtnInt")
            {
                numDecimalPoints.Visible = false;
                label4.Visible = false;
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            countTask = (int)nudCount.Value;

            int rbase = random.Next(mainInitialNumericSystem, mainLastNumericSystem);

            if (numDecimalPoints.Value != 0)
            {
                CurrentTask2 task = new CurrentTask2
                {
                    Type = "Task2",
                    numberFrom = initialNumber,
                    numberTo = lastNumber,
                    countTask = countTask,
                    numberSystemBase = rbase,
                    numberSysteEnd1 = initialNumericSystem,
                    numberSysteEnd2 = lastNumericSystem,
                    numberDecimalPoint = (int)numDecimalPoints.Value,
                };
                TemplateManager.AddTask(task);
            }
            else
            {
                CurrentTask1 task = new CurrentTask1
                {
                    Type = "Task1",
                    numberFrom = initialNumber,
                    numberTo = lastNumber,
                    countTask = countTask,
                    numberSystemBase = rbase,
                    numberSysteEnd1 = initialNumericSystem,
                    numberSysteEnd2 = lastNumericSystem,
                };
                TemplateManager.AddTask(task);
            }

            MessageBox.Show("Задачи были добавлены.\nПосле добавленя последний задачи, пожалуйста, создайте " +
                "шаблон!\nНеобходимо указаать его имя(оно должно быть уникальным) и нажать соответствующую кнопку");

            CreateForm.VisabilityCreatePatternElements(CreateForm.lblNamePattern, CreateForm.tbNamePattern, CreateForm.btnCreatePattern);
        }

        private void rbtnC1_10_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked && radioButton.Name == "rbtnC1")
            {
                panelC1.Visible = true;
            }
            else if (radioButton.Checked && radioButton.Name == "rbtnC10")
            {
                panelC1.Visible = false;
                mainLastNumericSystem = 10;
                mainInitialNumericSystem = 10;
                lblEndTask.Text = $"Итог:\r\nПеревести ( {"От " + initialNumber + " до " + lastNumber} ) с основанием {"От " + mainInitialNumericSystem + " до " + mainLastNumericSystem}  в {"От " + initialNumericSystem + " до " + lastNumericSystem} систему счисления.";
            }
        }
    }
}
