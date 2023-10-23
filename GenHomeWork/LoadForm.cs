using GenHomeWork.FormTask;
using GenHomeWork.Model;
using GenHomeWork.ViewController;
using Microsoft.Office.Interop.Word;
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
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
        }

        public static string pathQuest;
        public static string pathSolution;

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

        private void LoadForm_Load(object sender, EventArgs e)
        {
            TemplateManager.LoadTemplates();
            CreateFormManager.FillGridLoad(this.gridTemplates, TemplateManager.Templates);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void gridTemplates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Where where = new Where();
            where.ShowDialog();
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Вытаскивает название нажатой кнопки
                string columnName = gridTemplates.Columns[e.ColumnIndex].Name;

                DataGridViewRow row = gridTemplates.Rows[e.RowIndex];

                if (columnName == "print")
                {
                    string name = row.Cells["name"].Value.ToString();

                    TemplateManager.SelectTemplate(name, pathQuest, pathSolution);
                }
            }
        }
    }
}
