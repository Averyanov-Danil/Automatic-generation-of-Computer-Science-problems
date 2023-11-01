namespace GenHomeWork
{
    partial class CreateForm
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
            this.panelUp = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblNamePattern = new System.Windows.Forms.Label();
            this.tbNamePattern = new System.Windows.Forms.TextBox();
            this.btnCreatePattern = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panelUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(104)))), ((int)(((byte)(117)))));
            this.panelUp.Controls.Add(this.label2);
            this.panelUp.Controls.Add(this.btnExit);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(724, 41);
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
            this.btnExit.Location = new System.Drawing.Point(701, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 11;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(131)))), ((int)(((byte)(141)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 5);
            this.panel1.TabIndex = 1;
            // 
            // selectType
            // 
            this.selectType.FormattingEnabled = true;
            this.selectType.Items.AddRange(new object[] {
            "Тип №1",
            "Тип №2",
            "Тип №3",
            "Тип №4",
            "Тип №5",
            "Тип №6"});
            this.selectType.Location = new System.Drawing.Point(37, 74);
            this.selectType.Name = "selectType";
            this.selectType.Size = new System.Drawing.Size(155, 21);
            this.selectType.TabIndex = 2;
            this.selectType.SelectedIndexChanged += new System.EventHandler(this.selectType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тип задачи: ";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Location = new System.Drawing.Point(12, 108);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(700, 278);
            this.panelDesktop.TabIndex = 4;
            // 
            // lblNamePattern
            // 
            this.lblNamePattern.AutoSize = true;
            this.lblNamePattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNamePattern.ForeColor = System.Drawing.Color.White;
            this.lblNamePattern.Location = new System.Drawing.Point(515, 57);
            this.lblNamePattern.Name = "lblNamePattern";
            this.lblNamePattern.Size = new System.Drawing.Size(112, 13);
            this.lblNamePattern.TabIndex = 3;
            this.lblNamePattern.Text = "Назовите шаблон";
            // 
            // tbNamePattern
            // 
            this.tbNamePattern.Location = new System.Drawing.Point(518, 74);
            this.tbNamePattern.Name = "tbNamePattern";
            this.tbNamePattern.Size = new System.Drawing.Size(149, 20);
            this.tbNamePattern.TabIndex = 5;
            // 
            // btnCreatePattern
            // 
            this.btnCreatePattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreatePattern.FlatAppearance.BorderSize = 0;
            this.btnCreatePattern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreatePattern.ForeColor = System.Drawing.Color.White;
            this.btnCreatePattern.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnCreatePattern.IconColor = System.Drawing.Color.White;
            this.btnCreatePattern.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreatePattern.IconSize = 30;
            this.btnCreatePattern.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreatePattern.Location = new System.Drawing.Point(676, 74);
            this.btnCreatePattern.Name = "btnCreatePattern";
            this.btnCreatePattern.Size = new System.Drawing.Size(35, 23);
            this.btnCreatePattern.TabIndex = 9;
            this.btnCreatePattern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreatePattern.UseVisualStyleBackColor = true;
            this.btnCreatePattern.Click += new System.EventHandler(this.btnCreatePattern_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(279, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Создание шаблона";
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(104)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(724, 399);
            this.Controls.Add(this.btnCreatePattern);
            this.Controls.Add(this.tbNamePattern);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.lblNamePattern);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateForm";
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox selectType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnExit;
        public System.Windows.Forms.Label lblNamePattern;
        public System.Windows.Forms.TextBox tbNamePattern;
        public FontAwesome.Sharp.IconButton btnCreatePattern;
        private System.Windows.Forms.Label label2;
    }
}