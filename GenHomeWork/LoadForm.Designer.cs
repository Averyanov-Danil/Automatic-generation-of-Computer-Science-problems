namespace GenHomeWork
{
    partial class LoadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelUp = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridTemplates = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.print = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTemplates)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.Controls.Add(this.btnExit);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(716, 41);
            this.panelUp.TabIndex = 0;
            this.panelUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 20;
            this.btnExit.Location = new System.Drawing.Point(693, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 12;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(131)))), ((int)(((byte)(141)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 5);
            this.panel2.TabIndex = 1;
            // 
            // gridTemplates
            // 
            this.gridTemplates.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(104)))), ((int)(((byte)(117)))));
            this.gridTemplates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTemplates.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(131)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(131)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTemplates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTemplates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.desc,
            this.print,
            this.delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(104)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(131)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTemplates.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridTemplates.EnableHeadersVisualStyles = false;
            this.gridTemplates.Location = new System.Drawing.Point(12, 52);
            this.gridTemplates.Name = "gridTemplates";
            this.gridTemplates.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(131)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(131)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTemplates.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridTemplates.Size = new System.Drawing.Size(692, 366);
            this.gridTemplates.TabIndex = 2;
            this.gridTemplates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTemplates_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "Имя Шаблона";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 130;
            // 
            // desc
            // 
            this.desc.HeaderText = "Описание";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.Width = 380;
            // 
            // print
            // 
            this.print.HeaderText = "Печать";
            this.print.Name = "print";
            this.print.ReadOnly = true;
            this.print.Width = 70;
            // 
            // delete
            // 
            this.delete.HeaderText = "Удалить";
            this.delete.Name = "delete";
            this.delete.Width = 70;
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(104)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(716, 430);
            this.Controls.Add(this.gridTemplates);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadForm";
            this.Text = "LoadForm";
            this.Load += new System.EventHandler(this.LoadForm_Load);
            this.panelUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTemplates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridTemplates;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewButtonColumn print;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}