using FontAwesome.Sharp;
using GenHomeWork.FormTask;
using GenHomeWork.Model;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GenHomeWork
{
    public partial class CreateForm : Form
    {
        private Form currentChildForm;

        public CreateForm()
        {
            InitializeComponent();

            lblNamePattern.Visible = false;
            tbNamePattern.Visible = false;
            btnCreatePattern.Visible = false;

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
                OpenChildForm(new Type1F(this));
            }
            else if (selectType.SelectedItem.ToString() == "Тип №2")
            {
                OpenChildForm(new Type3F(this));
            }
            else if (selectType.SelectedItem.ToString() == "Тип №3")
            {
                OpenChildForm(new Type4F(this));
            }
            else if (selectType.SelectedItem.ToString() == "Тип №4")
            {
                OpenChildForm(new Type5F(this));
            }
            else if (selectType.SelectedItem.ToString() == "Тип №5")
            {
                OpenChildForm(new Type6F(this));
            }
            else if (selectType.SelectedItem.ToString() == "Тип №6")
            {
                OpenChildForm(new Type7F(this));
            }

        }

        private void btnCreatePattern_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbNamePattern.Text))
            {
                Template template = TemplateManager.CreateTemplate(tbNamePattern.Text);
                DialogResult result = MessageBox.Show("Шаблон был успешно добавлен\nЗакрыт данную форму?", "Шаблон добавлен", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Заполните название шаблона плиз");
            }
        }

        public void VisabilityCreatePatternElements(Label lblName, TextBox textBox, IconButton button)
        {
            lblName.Visible = true;
            textBox.Visible = true;
            button.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
