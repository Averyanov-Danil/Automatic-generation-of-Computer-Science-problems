namespace GenHomeWork.FormTask
{
    partial class Type4F
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
            this.lblDescTask = new System.Windows.Forms.Label();
            this.btnAddTask = new FontAwesome.Sharp.IconButton();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNum = new System.Windows.Forms.NumericUpDown();
            this.initialNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnC8 = new System.Windows.Forms.RadioButton();
            this.rbtnC10 = new System.Windows.Forms.RadioButton();
            this.rbtnC16 = new System.Windows.Forms.RadioButton();
            this.rbtnCRandom = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialNum)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescTask
            // 
            this.lblDescTask.AutoSize = true;
            this.lblDescTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescTask.ForeColor = System.Drawing.Color.White;
            this.lblDescTask.Location = new System.Drawing.Point(51, 25);
            this.lblDescTask.Name = "lblDescTask";
            this.lblDescTask.Size = new System.Drawing.Size(595, 26);
            this.lblDescTask.TabIndex = 5;
            this.lblDescTask.Text = "Пример:\r\nСколько {значащих нулей \\ единиц} в двоичной записи числа {число} с осно" +
    "ванием {8 \\ 10 \\ 16}?\r\n";
            this.lblDescTask.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTask.FlatAppearance.BorderSize = 0;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAddTask.IconColor = System.Drawing.Color.White;
            this.btnAddTask.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddTask.IconSize = 30;
            this.btnAddTask.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddTask.Location = new System.Drawing.Point(567, 247);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(118, 23);
            this.btnAddTask.TabIndex = 34;
            this.btnAddTask.Text = "Добавить";
            this.btnAddTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(530, 144);
            this.nudCount.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(120, 20);
            this.nudCount.TabIndex = 33;
            this.nudCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(543, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Кол-во задач";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "От:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(161, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "До:";
            // 
            // lastNum
            // 
            this.lastNum.Location = new System.Drawing.Point(195, 147);
            this.lastNum.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.lastNum.Name = "lastNum";
            this.lastNum.Size = new System.Drawing.Size(65, 20);
            this.lastNum.TabIndex = 35;
            this.lastNum.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // initialNum
            // 
            this.initialNum.Location = new System.Drawing.Point(86, 147);
            this.initialNum.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.initialNum.Name = "initialNum";
            this.initialNum.Size = new System.Drawing.Size(65, 20);
            this.initialNum.TabIndex = 36;
            this.initialNum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Диапозон числа";
            // 
            // rbtnC8
            // 
            this.rbtnC8.AutoSize = true;
            this.rbtnC8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbtnC8.ForeColor = System.Drawing.Color.White;
            this.rbtnC8.Location = new System.Drawing.Point(327, 105);
            this.rbtnC8.Name = "rbtnC8";
            this.rbtnC8.Size = new System.Drawing.Size(101, 17);
            this.rbtnC8.TabIndex = 40;
            this.rbtnC8.Text = "Основание 8";
            this.rbtnC8.UseVisualStyleBackColor = true;
            this.rbtnC8.CheckedChanged += new System.EventHandler(this.rbtnCC_CheckedChanged);
            // 
            // rbtnC10
            // 
            this.rbtnC10.AutoSize = true;
            this.rbtnC10.Checked = true;
            this.rbtnC10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbtnC10.ForeColor = System.Drawing.Color.White;
            this.rbtnC10.Location = new System.Drawing.Point(327, 128);
            this.rbtnC10.Name = "rbtnC10";
            this.rbtnC10.Size = new System.Drawing.Size(108, 17);
            this.rbtnC10.TabIndex = 40;
            this.rbtnC10.TabStop = true;
            this.rbtnC10.Text = "Основание 10";
            this.rbtnC10.UseVisualStyleBackColor = true;
            this.rbtnC10.CheckedChanged += new System.EventHandler(this.rbtnCC_CheckedChanged);
            // 
            // rbtnC16
            // 
            this.rbtnC16.AutoSize = true;
            this.rbtnC16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbtnC16.ForeColor = System.Drawing.Color.White;
            this.rbtnC16.Location = new System.Drawing.Point(327, 151);
            this.rbtnC16.Name = "rbtnC16";
            this.rbtnC16.Size = new System.Drawing.Size(108, 17);
            this.rbtnC16.TabIndex = 40;
            this.rbtnC16.Text = "Основание 16";
            this.rbtnC16.UseVisualStyleBackColor = true;
            this.rbtnC16.CheckedChanged += new System.EventHandler(this.rbtnCC_CheckedChanged);
            // 
            // rbtnCRandom
            // 
            this.rbtnCRandom.AutoSize = true;
            this.rbtnCRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbtnCRandom.ForeColor = System.Drawing.Color.White;
            this.rbtnCRandom.Location = new System.Drawing.Point(327, 174);
            this.rbtnCRandom.Name = "rbtnCRandom";
            this.rbtnCRandom.Size = new System.Drawing.Size(155, 17);
            this.rbtnCRandom.TabIndex = 40;
            this.rbtnCRandom.Text = "Основание случайное";
            this.rbtnCRandom.UseVisualStyleBackColor = true;
            this.rbtnCRandom.CheckedChanged += new System.EventHandler(this.rbtnCC_CheckedChanged);
            // 
            // Type4F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(104)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(700, 278);
            this.Controls.Add(this.rbtnCRandom);
            this.Controls.Add(this.rbtnC16);
            this.Controls.Add(this.rbtnC10);
            this.Controls.Add(this.rbtnC8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastNum);
            this.Controls.Add(this.initialNum);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblDescTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Type4F";
            this.Text = "Type4F";
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescTask;
        private FontAwesome.Sharp.IconButton btnAddTask;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown lastNum;
        private System.Windows.Forms.NumericUpDown initialNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnC8;
        private System.Windows.Forms.RadioButton rbtnC10;
        private System.Windows.Forms.RadioButton rbtnC16;
        private System.Windows.Forms.RadioButton rbtnCRandom;
    }
}