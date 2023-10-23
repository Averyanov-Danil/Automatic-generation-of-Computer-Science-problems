using GenHomeWork.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenHomeWork
{
    public partial class SForm : Form
    {
        public SForm()
        {
            InitializeComponent();
            //if (TemplateManager.count > 0) { lblPatternCount.Text = Pattern.count.ToString(); }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void SForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_createPattern_Click(object sender, EventArgs e)
        {
           var form = new CreateForm();
            this.Hide();
            form.Show();
        }

        private void btn_loadPattern_Click(object sender, EventArgs e)
        {
            var form = new LoadForm();
            this.Hide();
            form.Show();
        }
    }
}
