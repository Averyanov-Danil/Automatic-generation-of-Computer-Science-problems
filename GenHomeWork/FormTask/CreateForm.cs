using GenHomeWork.FormTask;
using GenHomeWork.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenHomeWork
{
    public partial class CreateForm : Form
    {
        private Form currentChildForm;

        public CreateForm()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelUp_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void selectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectType.SelectedItem.ToString() == "Тип №1")
            {
                OpenChildForm(new TypeOneF());
            }
        }

        private void btnCreatePattern_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbNamePattern.Text))
            {
                Template template = TemplateManager.CreateTemplate(tbNamePattern.Text);
            }
            else
            {
                MessageBox.Show("Заполните название шаблона плиз");
            }
        }

        public static void VisabilityCreatePatternElements()
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            SForm sForm = new SForm();
            sForm.Show();
        }
    }
}
