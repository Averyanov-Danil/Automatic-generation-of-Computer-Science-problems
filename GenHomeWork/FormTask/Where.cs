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
    public partial class Where : Form
    {
        public Where()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm.pathQuest = @textBox1.Text + "tasks.docx";
            LoadForm.pathSolution = @textBox2.Text + "solution.docx";
            this.Close();
        }
    }
}
