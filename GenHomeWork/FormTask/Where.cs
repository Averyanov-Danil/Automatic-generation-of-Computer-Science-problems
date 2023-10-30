using GenHomeWork.SupportClasses;
using System;
using System.Windows.Forms;

namespace GenHomeWork.FormTask
{
    public partial class Where : Form
    {
        public Where()
        {
            InitializeComponent();
            textBox1.Text = FolderHelper.TaskPath;
            textBox2.Text = FolderHelper.SolutionPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm.pathQuest = @textBox1.Text + @"\";
            LoadForm.pathSolution = @textBox2.Text + @"\";
            this.Close(); 
        }

        private void btnFolderSearch_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Выберите директорию";
                
                folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // Откройте диалоговое окно выбора директории
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedDirectory = folderBrowserDialog.SelectedPath;
                    
                    textBox1.Text = @selectedDirectory;
                    textBox2.Text = @selectedDirectory;
                    FolderHelper.TaskPath = @selectedDirectory;
                    FolderHelper.SolutionPath = @selectedDirectory;
                }
            }
        }

        //private void btnExit_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
    }
}
